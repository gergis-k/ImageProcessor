namespace ImageProcessor
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.median10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMax5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxIn2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIn1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxOut1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstImageToolStripMenuItem,
            this.secondImageToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // firstImageToolStripMenuItem
            // 
            this.firstImageToolStripMenuItem.Name = "firstImageToolStripMenuItem";
            this.firstImageToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.firstImageToolStripMenuItem.Text = "First Image";
            this.firstImageToolStripMenuItem.Click += new System.EventHandler(this.firstImageToolStripMenuItem_Click);
            // 
            // secondImageToolStripMenuItem
            // 
            this.secondImageToolStripMenuItem.Name = "secondImageToolStripMenuItem";
            this.secondImageToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.secondImageToolStripMenuItem.Text = "Second Image";
            this.secondImageToolStripMenuItem.Click += new System.EventHandler(this.secondImageToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.median10x10ToolStripMenuItem,
            this.minMax5x5ToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // median10x10ToolStripMenuItem
            // 
            this.median10x10ToolStripMenuItem.Name = "median10x10ToolStripMenuItem";
            this.median10x10ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.median10x10ToolStripMenuItem.Text = "Median 5x5";
            this.median10x10ToolStripMenuItem.Click += new System.EventHandler(this.median10x10ToolStripMenuItem_Click);
            // 
            // minMax5x5ToolStripMenuItem
            // 
            this.minMax5x5ToolStripMenuItem.Name = "minMax5x5ToolStripMenuItem";
            this.minMax5x5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minMax5x5ToolStripMenuItem.Text = "MinMax 5x5";
            this.minMax5x5ToolStripMenuItem.Click += new System.EventHandler(this.minMax5x5ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBoxIn2);
            this.groupBox1.Controls.Add(this.pictureBoxIn1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 677);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 601);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(272, 40);
            this.button7.TabIndex = 11;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 555);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(272, 40);
            this.button6.TabIndex = 10;
            this.button6.Text = "Histogram";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Gray Scale";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(201, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Blue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(96, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Green";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Red";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxIn2
            // 
            this.pictureBoxIn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIn2.Location = new System.Drawing.Point(6, 210);
            this.pictureBoxIn2.Name = "pictureBoxIn2";
            this.pictureBoxIn2.Size = new System.Drawing.Size(272, 183);
            this.pictureBoxIn2.TabIndex = 1;
            this.pictureBoxIn2.TabStop = false;
            this.pictureBoxIn2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIn2_MouseDoubleClick);
            // 
            // pictureBoxIn1
            // 
            this.pictureBoxIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIn1.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxIn1.Name = "pictureBoxIn1";
            this.pictureBoxIn1.Size = new System.Drawing.Size(272, 183);
            this.pictureBoxIn1.TabIndex = 0;
            this.pictureBoxIn1.TabStop = false;
            this.pictureBoxIn1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIn1_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.pictureBoxOut1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(284, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1065, 677);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Image";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(612, 464);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Histogram";
            // 
            // pictureBoxOut1
            // 
            this.pictureBoxOut1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOut1.Location = new System.Drawing.Point(3, 18);
            this.pictureBoxOut1.Name = "pictureBoxOut1";
            this.pictureBoxOut1.Size = new System.Drawing.Size(1059, 656);
            this.pictureBoxOut1.TabIndex = 0;
            this.pictureBoxOut1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxOut1;
        private System.Windows.Forms.PictureBox pictureBoxIn2;
        private System.Windows.Forms.PictureBox pictureBoxIn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem median10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMax5x5ToolStripMenuItem;
    }
}