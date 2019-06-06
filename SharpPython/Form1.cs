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

namespace SharpPython
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<String> FileExtensions = new List<string>();

            FileExtensions.Add("*.png");
            FileExtensions.Add("*.jpg");

            FillListBox(ListPicture, @"input", FileExtensions);
        }

        private void BtnRunPython_Click(object sender, EventArgs e)
        {
            string pyPath = @"C:\Users\Александр\AppData\Local\Programs\Python\Python37-32\python.exe";
            string pyScript = @"C:\Users\Александр\source\SharpPython\SharpPython\bin\Debug\main.py";

            
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

        private void BtnConvert_Click(object sender, EventArgs e)
        {
           
        }

        private void ListPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var fromFile = Image.FromFile(@"input/" + ListPicture.GetItemText(ListPicture.SelectedItem)))
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