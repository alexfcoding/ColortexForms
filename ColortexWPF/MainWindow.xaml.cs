using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;

namespace ColortexWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> FileExtensions = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            
            watchFiles();

            FileExtensions.Add("*.png");
            FileExtensions.Add("*.jpg");

            FillListBox(listSource, @"prepare", FileExtensions);

            FillListBox(listProcessed, @"output", FileExtensions);

            pythonPath.Text = LoadConfig(pythonPath)[0];
        }

        private void watchFiles()
        {
            FileSystemWatcher watcherInput = new FileSystemWatcher();
            
            watcherInput.Path = @"prepare";
            watcherInput.NotifyFilter = NotifyFilters.LastWrite;
            watcherInput.Filter = "*.*";
            watcherInput.Changed += new FileSystemEventHandler(OnNewFilesFound);
            watcherInput.EnableRaisingEvents = true;

            FileSystemWatcher watcherOutput = new FileSystemWatcher();
            
            watcherOutput.Path = @"output";
            watcherOutput.NotifyFilter = NotifyFilters.LastWrite;
            watcherOutput.Filter = "*.*";
            watcherOutput.Changed += new FileSystemEventHandler(OnNewFilesFound);
            watcherOutput.EnableRaisingEvents = true;
        }

        public void OnNewFilesFound(object source, FileSystemEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() => refreshList()));
        }

        public void refreshList()
        {
            listSource.Items.Clear();
            FillListBox(listSource, @"prepare", FileExtensions);

            listProcessed.Items.Clear();
            FillListBox(listProcessed, @"output", FileExtensions);
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

        private void FillListBox(ListBox inputListbox, string Folder, List<string> FileExtensions)
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

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            string pyPath = pythonPath.Text;
            string pyScript = @"main.py";

            System.IO.DirectoryInfo di = new DirectoryInfo("input");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            if (listSource.SelectedItem != null)
            {
                var encoder = new JpegBitmapEncoder(); // Or any other, e.g. PngBitmapEncoder for PNG.
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imageRenderer.Source));
                encoder.QualityLevel = 100; // Set quality level 1-100.

                using (var stream = new FileStream(@"input/" + listSource.SelectedItem.ToString(), FileMode.Create))
                {
                    encoder.Save(stream);
                }

                Thread.Sleep(200);
                ExecutePython(pyPath, pyScript);
            }
        }

        private void ExecutePython(string pythonPath, string scriptName)
        {
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(pythonPath);
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.Arguments = "main.py";
            Process myProcess = new Process();
            myProcess.StartInfo = myProcessStartInfo;
            myProcess.Start();
        }

        private static BitmapFrame CreateResizedImage(ImageSource source, int width, int height, int margin)
        {
            var rect = new Rect(margin, margin, width - margin * 2, height - margin * 2);

            var group = new DrawingGroup();
            RenderOptions.SetBitmapScalingMode(group, BitmapScalingMode.HighQuality);
            group.Children.Add(new ImageDrawing(source, rect));

            var drawingVisual = new DrawingVisual();
            using (var drawingContext = drawingVisual.RenderOpen())
                drawingContext.DrawDrawing(group);

            var resizedImage = new RenderTargetBitmap(
                width, height,         // Resized dimensions
                96, 96,                // Default DPI values
                PixelFormats.Default); // Default pixel format
            resizedImage.Render(drawingVisual);

            return BitmapFrame.Create(resizedImage);
        }

        private void ListSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            if (listSource.SelectedItem != null)
            { 
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(@"prepare\" + listSource.SelectedItem.ToString(), UriKind.Relative);
                image.EndInit();
                imageRenderer.Source = image;
            }
            listProcessed.UnselectAll();
        }

        private void ListProcessed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listProcessed.SelectedItem != null)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(@"output\" + listProcessed.SelectedItem.ToString(), UriKind.Relative);
                image.EndInit();
                imageRenderer.Source = image;
            }
            listSource.UnselectAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            BitmapFrame bitmap = CreateResizedImage(imageRenderer.Source, (int)(imageRenderer.Source.Width / 1.2), (int)(imageRenderer.Source.Height / 1.2), 0);
                        
            imageRenderer.Source = bitmap;
        }
    }
}
