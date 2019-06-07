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
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ColortexForms
{       
    public partial class Main : Form
    {
        List<String> FileExtensions = new List<string>();
                
        public Main()
        {
            InitializeComponent();
            
            watchFiles();
            
            pythonPath.Text = LoadConfig(pythonPath)[0];

            FileExtensions.Add("*.png");
            FileExtensions.Add("*.jpg");

            FillListBox(ListSourceImg, @"prepare", FileExtensions);

            FillListBox(ListProcessImg, @"output", FileExtensions);
        }

        private string[] LoadConfig(TextBox pythonPath)
        {
            string path = @"config.txt";

            string[] configLines;
            var list = new List<string>();
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            configLines = list.ToArray();
            return configLines;
        }

        public void OnNewFilesFound(object source, FileSystemEventArgs e)
        {
            refreshList();
        }

        public void refreshList()
        {
            ListSourceImg.Items.Clear();
            FillListBox(ListSourceImg, @"prepare", FileExtensions);

            ListProcessImg.Items.Clear();
            FillListBox(ListProcessImg, @"output", FileExtensions);
        }

        private void watchFiles()
        {
            FileSystemWatcher watcherInput = new FileSystemWatcher();
            watcherInput.SynchronizingObject = this;
            watcherInput.Path = @"prepare";
            watcherInput.NotifyFilter = NotifyFilters.LastWrite;
            watcherInput.Filter = "*.*";
            watcherInput.Changed += new FileSystemEventHandler(OnNewFilesFound);
            watcherInput.EnableRaisingEvents = true;

            FileSystemWatcher watcherOutput = new FileSystemWatcher();
            watcherOutput.SynchronizingObject = this;
            watcherOutput.Path = @"output";
            watcherOutput.NotifyFilter = NotifyFilters.LastWrite;
            watcherOutput.Filter = "*.*";
            watcherOutput.Changed += new FileSystemEventHandler(OnNewFilesFound);
            watcherOutput.EnableRaisingEvents = true;            
        }

        private void BtnRunPython_Click(object sender, EventArgs e)
        {
            string pyPath = pythonPath.Text;
            string pyScript = @"main.py";

            System.IO.DirectoryInfo di = new DirectoryInfo("input");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            if (ListSourceImg.SelectedItem != null)
            {                
                PictureRenderer.Image.Save("input/" + ListSourceImg.GetItemText(ListSourceImg.SelectedItem));
                Thread.Sleep(200);
                ExecutePython(pyPath, pyScript);
            }
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

        private void ListChecked_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (ListSourceImg.SelectedItem != null)
                using (var fromFile = Image.FromFile(@"prepare/" + ListSourceImg.GetItemText(ListSourceImg.SelectedItem)))
                {
                    PictureRenderer.Image = new Bitmap(fromFile);
                }              
        }

        private void ListProcessImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListProcessImg.SelectedItem != null)
                using (var fromFile = Image.FromFile(@"output/" + ListProcessImg.GetItemText(ListProcessImg.SelectedItem)))
                {
                    PictureRenderer.Image = new Bitmap(fromFile);
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
            PictureRenderer.Image = ResizeImage(PictureRenderer.Image, PictureRenderer.Image.Width / 2, PictureRenderer.Image.Height / 2);
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            string sPath = "config.txt";
            System.IO.StreamWriter configFile = new System.IO.StreamWriter(sPath);
            configFile.Write(pythonPath.Text);
            configFile.Close();
        }

        private void ListSourceImg_MouseClick(object sender, MouseEventArgs e)
        {
            BtnRunPython.Enabled = true;
        }

        private void ListProcessImg_MouseClick(object sender, MouseEventArgs e)
        {
            BtnRunPython.Enabled = false;
        }
    }
}
