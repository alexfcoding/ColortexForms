using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SharpPython
{
    public partial class Form1 : Form
    {
        List<String> FileExtensions = new List<string>();

        public Form1()
        {
            InitializeComponent();                        

            FileExtensions.Add("*.png");
            FileExtensions.Add("*.jpg");

            FillListBox(ListSourceImg, @"prepare", FileExtensions);
        }

        private void BtnRunPython_Click(object sender, EventArgs e)
        {
            string pyPath = @"C:\Users\Александр\AppData\Local\Programs\Python\Python37-32\python.exe";
            string pyScript = @"C:\Users\Александр\source\SharpPython\SharpPython\bin\Debug\main.py";

            System.IO.DirectoryInfo di = new DirectoryInfo("input");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            PictureSVGRender.Image.Save("input/" + ListSourceImg.GetItemText(ListSourceImg.SelectedItem));
            Thread.Sleep(200);

            ExecutePython(pyPath, pyScript);
        }
        
        private void FillListBox(ListBox inputListbox, string Folder, List <string> FileExtensions)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Folder);

            for (int i = 0; i < FileExtensions.Count; i++)
            {
                FileInfo[] Files = dirInfo.GetFiles(FileExtensions[i]);

                foreach (FileInfo file in Files)
                {
                    inputListbox.Items.Add(file.Name);
                }
            }            
        }

        private void ExecutePython (string pythonPath, string scriptName)
        {           
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(pythonPath);
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;                        
            myProcessStartInfo.Arguments = "main.py";
            Process myProcess = new Process();            
            myProcess.StartInfo = myProcessStartInfo;     
            myProcess.Start();
            
        }

        private void RenderSVG (string filePath)
        {
            var svgDoc = SvgDocument.Open(filePath);

            PictureSVGRender.Image = svgDoc.Draw();
        }
        private void BtnDrawSVG_Click(object sender, EventArgs e)
        {
            string svgPath = @"C:\Users\Александр\source\SharpPython\SharpPython\bin\Debug\random_tree_001.svg";

            RenderSVG(svgPath);
        }
        
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {
           
        }        

        private void ListChecked_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var fromFile = Image.FromFile(@"prepare/" + ListSourceImg.GetItemText(ListSourceImg.SelectedItem)))
            {
                PictureSVGRender.Image = new Bitmap(fromFile);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ListSourceImg.Items.Clear();
            ListProcessImg.Items.Clear();
            FillListBox(ListSourceImg, @"prepare", FileExtensions);
            FillListBox(ListProcessImg, @"output", FileExtensions);
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            PictureSVGRender.Image = ResizeImage(PictureSVGRender.Image, PictureSVGRender.Image.Width / 2, PictureSVGRender.Image.Height / 2);
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {

        }

        private void PictureSVGRender_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListProcessImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var fromFile = Image.FromFile(@"output/" + ListSourceImg.GetItemText(ListProcessImg.SelectedItem)))
            {
                PictureSVGRender.Image = new Bitmap(fromFile);
            }
        }
    }
}
//randomNum = rndNum.Next(0, 255);
//byte red = Convert.ToByte(randomNum);
//randomNum = rndNum.Next(0, 255);
//byte green = Convert.ToByte(randomNum);
//randomNum = rndNum.Next(0, 255);
//byte blue = Convert.ToByte(randomNum); ;