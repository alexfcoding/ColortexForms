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


namespace SharpPython
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRunPython_Click(object sender, EventArgs e)
        {
            string pyPath = @"C:\Users\Александр\AppData\Local\Programs\Python\Python37\python.exe";
            string pyScript = @"C:\Users\Александр\source\SharpPython\SharpPython\bin\Debug\main.py";

            ExecutePython(pyPath, pyScript);
        }

        private void ExecutePython (string pythonPath, string scriptName)
        {
            Process p = new Process();
            p.StartInfo.FileName = pythonPath;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.Arguments = scriptName;                    
            p.Start();
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

        
    }
}
//randomNum = rndNum.Next(0, 255);
//byte red = Convert.ToByte(randomNum);
//randomNum = rndNum.Next(0, 255);
//byte green = Convert.ToByte(randomNum);
//randomNum = rndNum.Next(0, 255);
//byte blue = Convert.ToByte(randomNum); ;