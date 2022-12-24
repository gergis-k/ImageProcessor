using openCV;
using System.Drawing;

namespace ImageProcessor.Interfaces
{
    public interface IOutputImage
    {
        IplImage IMAGE_RED { get; set; }
        IplImage IMAGE_GREEN { get; set; }
        IplImage IMAGE_BLUE { get; set; }
        Bitmap IMAGE_GRAY_SCALE { get; set; }
        Bitmap FILTERED_IMAGE { get; set; }
        IplImage MERGED_IMAGE { get; set; }
    }
}
