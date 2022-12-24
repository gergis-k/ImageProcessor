using ImageProcessor.Interfaces;
using openCV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessor
{
    public partial class HomeForm : Form, IInputImage, IOutputImage
    {
        private IplImage iMAGE1;
        private IplImage iMAGE2;
        private IplImage iMAGE_RED;
        private IplImage iMAGE_GREEN;
        private IplImage iMAGE_BLUE;
        private Bitmap iMAGE_GRAY_SCALE;
        private IplImage mERGED_IMAGE;
        private Bitmap fILTERED_IMAGE;

        public IplImage IMAGE1 { get => iMAGE1; set => iMAGE1 = value; }
        public IplImage IMAGE2 { get => iMAGE2; set => iMAGE2 = value; }
        public IplImage IMAGE_RED { get => iMAGE_RED; set => iMAGE_RED = value; }
        public IplImage IMAGE_GREEN { get => iMAGE_GREEN; set => iMAGE_GREEN = value; }
        public IplImage IMAGE_BLUE { get => iMAGE_BLUE; set => iMAGE_BLUE = value; }
        public Bitmap IMAGE_GRAY_SCALE { get => iMAGE_GRAY_SCALE; set => iMAGE_GRAY_SCALE = value; }
        public IplImage MERGED_IMAGE { get => mERGED_IMAGE; set => mERGED_IMAGE = value; }
        public Bitmap FILTERED_IMAGE { get => fILTERED_IMAGE; set => fILTERED_IMAGE = value; }

        public HomeForm()
        {
            InitializeComponent();
            TOGGLE_BUTTONS();
            chart1.Visible = false;
        }



        #region Private
        private void INITIALIZE_DIALOG()
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Title = "Choose an image";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.";
        }
        private void LOAD_IMAGE(ref PictureBox pictureBox, ref IplImage iplImage)
        {
            INITIALIZE_DIALOG();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iplImage = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                    CvSize size = new CvSize(pictureBox.Width, pictureBox.Height);
                    IplImage resized_image = cvlib.CvCreateImage(size, iplImage.depth, iplImage.nChannels);
                    cvlib.CvResize(ref iplImage, ref resized_image, cvlib.CV_INTER_LINEAR);
                    pictureBox.Image = (System.Drawing.Image)resized_image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            TOGGLE_BUTTONS();
        }
        private void EXTRACT_RED_GREEN_BLUE()
        {
            iMAGE_RED = cvlib.CvCreateImage(new CvSize(iMAGE1.width, iMAGE1.height), iMAGE1.depth, iMAGE1.nChannels);
            iMAGE_GREEN = cvlib.CvCreateImage(new CvSize(iMAGE1.width, iMAGE1.height), iMAGE1.depth, iMAGE1.nChannels);
            iMAGE_BLUE = cvlib.CvCreateImage(new CvSize(iMAGE1.width, iMAGE1.height), iMAGE1.depth, iMAGE1.nChannels);
            int sourceAdd = iMAGE1.imageData.ToInt32();
            int destinationAdd_RED = IMAGE_RED.imageData.ToInt32();
            int destinationAdd_GREEN = iMAGE_GREEN.imageData.ToInt32();
            int destinationAdd_BULE = iMAGE_BLUE.imageData.ToInt32();
            unsafe
            {
                int sourceIndexR, sourceIndexG, sourceIndexB, destinationIndexR, destinationIndexG, destinationIndexB;
                for (int r = 0; r < iMAGE_RED.height; ++r)
                    for (int c = 0; c < iMAGE_RED.width; ++c)
                    {
                        sourceIndexR = destinationIndexR = (iMAGE_RED.width * r * iMAGE_RED.nChannels) + (c * iMAGE_RED.nChannels);
                        *(byte*)(destinationAdd_RED + destinationIndexR + 0) = 0;
                        *(byte*)(destinationAdd_RED + destinationIndexR + 1) = 0;
                        *(byte*)(destinationAdd_RED + destinationIndexR + 2) = *(byte*)(sourceAdd + sourceIndexR + 2);

                        sourceIndexG = destinationIndexG = (iMAGE_RED.width * r * iMAGE_RED.nChannels) + (c * iMAGE_RED.nChannels);
                        *(byte*)(destinationAdd_GREEN + destinationIndexG + 0) = 0;
                        *(byte*)(destinationAdd_GREEN + destinationIndexG + 1) = *(byte*)(sourceAdd + sourceIndexG + 1);
                        *(byte*)(destinationAdd_GREEN + destinationIndexG + 2) = 0;

                        sourceIndexB = destinationIndexB = (iMAGE_RED.width * r * iMAGE_RED.nChannels) + (c * iMAGE_RED.nChannels);
                        *(byte*)(destinationAdd_BULE + destinationIndexB + 0) = *(byte*)(sourceAdd + sourceIndexB + 0);
                        *(byte*)(destinationAdd_BULE + destinationIndexB + 1) = 0;
                        *(byte*)(destinationAdd_BULE + destinationIndexB + 2) = 0;
                    }
            }
        }
        private void SHOW_IMAGE(ref IplImage imageToOut)
        {
            pictureBoxOut1.Image = (System.Drawing.Image)imageToOut;
        }
        private void CONVERT_TO_GRAY_SCALE()
        {
            iMAGE_GRAY_SCALE = (Bitmap)iMAGE1;
            int width = iMAGE_GRAY_SCALE.Width;
            int height = iMAGE_GRAY_SCALE.Height;
            Color p;
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    p = iMAGE_GRAY_SCALE.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    iMAGE_GRAY_SCALE.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
        }
        private void MERGE(ref IplImage image1, ref IplImage image2)
        {
            CvSize size = new CvSize(pictureBoxOut1.Width, pictureBoxOut1.Height);

            IplImage resized_image1 = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
            cvlib.CvResize(ref image1, ref resized_image1, cvlib.CV_INTER_LINEAR);

            IplImage resized_image2 = cvlib.CvCreateImage(size, image2.depth, image2.nChannels);
            cvlib.CvResize(ref image2, ref resized_image2, cvlib.CV_INTER_LINEAR);

            MERGED_IMAGE = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);


            int sourceX = resized_image1.imageData.ToInt32();
            int sourceY = resized_image2.imageData.ToInt32();
            int dstAddress = MERGED_IMAGE.imageData.ToInt32();
            unsafe
            {
                for (int r = 0; r < MERGED_IMAGE.height; ++r)
                {
                    for (int c = 0; c < MERGED_IMAGE.width; ++c)
                    {
                        int sourceIndexX, sourceIndexY, disIndex;

                        sourceIndexX = (resized_image1.width * r * resized_image1.nChannels) + (resized_image1.nChannels * c);
                        sourceIndexY = (resized_image2.width * r * resized_image2.nChannels) + (resized_image2.nChannels * c);
                        disIndex = (MERGED_IMAGE.width * r * MERGED_IMAGE.nChannels) + (MERGED_IMAGE.nChannels * c);

                        byte* redX = (byte*)(sourceX + sourceIndexX + 2);
                        byte* greenX = (byte*)(sourceX + sourceIndexX + 1);
                        byte* blueX = (byte*)(sourceX + sourceIndexX + 0);

                        byte* redY = (byte*)(sourceY + sourceIndexY + 2);
                        byte* greenY = (byte*)(sourceY + sourceIndexY + 1);
                        byte* blueY = (byte*)(sourceY + sourceIndexY + 0);

                        byte red = (byte)Math.Min(255, (*redX + *redY));
                        byte green = (byte)Math.Min(255, (*greenX + *greenY));
                        byte blue = (byte)Math.Min(255, (*blueX + *blueY));

                        *(byte*)(dstAddress + disIndex + 2) = red;
                        *(byte*)(dstAddress + disIndex + 1) = green;
                        *(byte*)(dstAddress + disIndex + 0) = blue;
                    }
                }

            }

        }
        private void TOGGLE_BUTTONS()
        {
            button2.Enabled = pictureBoxIn1.Image != null;
            button3.Enabled = pictureBoxIn1.Image != null;
            button4.Enabled = pictureBoxIn1.Image != null;
            button5.Enabled = pictureBoxIn1.Image != null;
            button6.Enabled = pictureBoxIn1.Image != null;
            button1.Enabled = pictureBoxIn1.Image != null && pictureBoxIn2.Image != null;
            median10x10ToolStripMenuItem.Enabled = pictureBoxIn1.Image != null;
            minMax5x5ToolStripMenuItem.Enabled = pictureBoxIn1.Image != null;
        }
        private void HISTOGRAM()
        {
            chart1.Series.Clear();
            var redS = new Series("Red");
            var greenS = new Series("Green");
            var blueS = new Series("Blue");
            redS.Color = Color.Red;
            greenS.Color = Color.Green;
            blueS.Color = Color.Blue;

            chart1.Series.Add(redS);
            chart1.Series.Add(greenS);
            chart1.Series.Add(blueS);

            Bitmap bmpImg = (Bitmap)iMAGE1;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;
            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < hieght; ++j)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);
                    ++ni_Red[pixelColor.R];
                    ++ni_Green[pixelColor.G];
                    ++ni_Blue[pixelColor.B];
                }
            }
            for (int i = 0; i < 256; ++i)
            {
                chart1.Series["Red"].Points.AddY(ni_Red[i]);
                chart1.Series["Green"].Points.AddY(ni_Green[i]);
                chart1.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }
        private void APPLAY_MEDIAN_5x5_FILTER(ref IplImage image1)
        {

            CvSize size = new CvSize(image1.width, image1.height);
            var temp = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
            cvlib.CvResize(ref image1, ref temp, cvlib.CV_INTER_LINEAR);
            var srcImg = (Bitmap)temp;

            FILTERED_IMAGE = new Bitmap(srcImg.Width, srcImg.Height, srcImg.PixelFormat);

            int rows = srcImg.Height;
            int cols = srcImg.Width;
            Color px;

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    int rF = Math.Max(0, r - 4);
                    int cF = Math.Max(0, c - 4);

                    List<int> redList = new List<int>(); 
                    List<int> greenList = new List<int>();
                    List<int> blueList = new List<int>();
                    int a = 0;
                    for (; (rF < rows) && (rF <= (r + 4)); ++rF)
                    {
                        for (; (cF < cols) && (cF <= (c + 4)); ++cF)
                        {
                            px = srcImg.GetPixel(cF, rF);
                            a = px.A;
                            int red = px.R;
                            int green = px.G;
                            int blue = px.B;
                            redList.Add(red);
                            greenList.Add(green);
                            blueList.Add(blue);
                        }
                    }
                    redList.Sort();
                    greenList.Sort();
                    blueList.Sort();

                    int medianRed, medianGreen, medianBlue;

                    if (redList.Count % 2 != 0)
                        medianRed = redList.ElementAt(redList.Count / 2) + redList.ElementAt((redList.Count / 2) + 1) / 2;
                    else
                        medianRed = redList.ElementAt(redList.Count / 2);

                    if (greenList.Count % 2 != 0)
                        medianGreen = greenList.ElementAt(greenList.Count / 2) + greenList.ElementAt((greenList.Count / 2) + 1) / 2;
                    else
                        medianGreen = greenList.ElementAt(greenList.Count / 2);

                    if (blueList.Count % 2 != 0)
                        medianBlue = blueList.ElementAt(blueList.Count / 2) + blueList.ElementAt((blueList.Count / 2) + 1) / 2;
                    else
                        medianBlue = blueList.ElementAt(blueList.Count / 2);

                    medianRed = Math.Min(medianRed, 255);
                    medianGreen = Math.Min(medianGreen, 255);
                    medianBlue = Math.Min(medianBlue, 255);

                    FILTERED_IMAGE.SetPixel(c, r, Color.FromArgb(a, medianRed, medianGreen, medianBlue));

                }
            }

            pictureBoxOut1.Image = FILTERED_IMAGE;
        }

        private void APPLAY_MIN_MAX_5x5_FILTER(ref IplImage image1)
        {

            CvSize size = new CvSize(image1.width, image1.height);
            var temp = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
            cvlib.CvResize(ref image1, ref temp, cvlib.CV_INTER_LINEAR);
            var srcImg = (Bitmap)temp;

            FILTERED_IMAGE = new Bitmap(srcImg.Width, srcImg.Height, srcImg.PixelFormat);

            int rows = srcImg.Height;
            int cols = srcImg.Width;
            Color px;

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    int rF = Math.Max(0, r - 4);
                    int cF = Math.Max(0, c - 4);

                    List<int> redList = new List<int>();
                    List<int> greenList = new List<int>();
                    List<int> blueList = new List<int>();
                    int a = 0;
                    for (; (rF < rows) && (rF <= (r + 4)); ++rF)
                    {
                        for (; (cF < cols) && (cF <= (c + 4)); ++cF)
                        {
                            px = srcImg.GetPixel(cF, rF);
                            a = px.A;
                            int red = px.R;
                            int green = px.G;
                            int blue = px.B;
                            redList.Add(red);
                            greenList.Add(green);
                            blueList.Add(blue);
                        }
                    }
                    redList.Sort();
                    greenList.Sort();
                    blueList.Sort();

                    int medianRed, medianGreen, medianBlue;

                    medianRed = redList.ElementAt(0) + redList.ElementAt(redList.Count - 1) / 2;

                    medianGreen = greenList.ElementAt(0) + greenList.ElementAt(greenList.Count - 1) / 2;

                    medianBlue = blueList.ElementAt(0) + blueList.ElementAt(blueList.Count - 1) / 2;

                    medianRed = Math.Min(medianRed, 255);
                    medianGreen = Math.Min(medianGreen, 255);
                    medianBlue = Math.Min(medianBlue, 255);

                    FILTERED_IMAGE.SetPixel(c, r, Color.FromArgb(a, medianRed, medianGreen, medianBlue));

                }
            }

            pictureBoxOut1.Image = FILTERED_IMAGE;
        }
        #endregion



        private void firstImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOAD_IMAGE(ref pictureBoxIn1, ref iMAGE1);
            EXTRACT_RED_GREEN_BLUE();
            CONVERT_TO_GRAY_SCALE();
        }

        private void secondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOAD_IMAGE(ref pictureBoxIn2, ref iMAGE2);
        }

        private void pictureBoxIn1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LOAD_IMAGE(ref pictureBoxIn1, ref iMAGE1);
            EXTRACT_RED_GREEN_BLUE();
            CONVERT_TO_GRAY_SCALE();
        }

        private void pictureBoxIn2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LOAD_IMAGE(ref pictureBoxIn2, ref iMAGE2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            MERGE(ref iMAGE1, ref iMAGE2);
            SHOW_IMAGE(ref mERGED_IMAGE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            SHOW_IMAGE(ref iMAGE_RED);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            SHOW_IMAGE(ref iMAGE_GREEN);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            SHOW_IMAGE(ref iMAGE_BLUE);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Series.Clear();
            chart1.Visible = false;
            pictureBoxOut1.Image = IMAGE_GRAY_SCALE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HISTOGRAM();
            pictureBoxOut1.Visible = false;
            chart1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBoxIn1.Image = null;
            pictureBoxIn2.Image = null;
            pictureBoxOut1.Image = null;
            chart1.Visible = false;
            TOGGLE_BUTTONS();
        }

        private void median10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            APPLAY_MEDIAN_5x5_FILTER(ref iMAGE1);
        }

        private void minMax5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxOut1.Visible = true;
            chart1.Visible = false;
            APPLAY_MIN_MAX_5x5_FILTER(ref iMAGE1);
        }
    }
}
