using Doppler.Utils;
using NLog;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class ImageToPdfConverter : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private FlowLayoutPanel FlowLayoutFiles;
        private ProgressBar ProgressBar;
        private Button ResetButton, ConverterButton;

        private List<DopplerFile> Files = new List<DopplerFile> { };

        public ImageToPdfConverter(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["flowLayoutFiles2"] is FlowLayoutPanel flp)
                FlowLayoutFiles = flp;
            FlowLayoutFiles.DragDrop += HandleDragDrop;
            FlowLayoutFiles.DragEnter += HandleDragEnter;
            
            if (tab.Controls["progressBar2"] is ProgressBar pn)
                ProgressBar = pn;

            if (tab.Controls["resetFiles2"] is Button btn)
                ResetButton = btn;
            ResetButton.Click += ResetFiles;

            if (tab.Controls["ImageToPdfButton"] is Button btn2)
                ConverterButton = btn2;
            ConverterButton.Click += Launch;
        }

        /// <summary>
        /// Combine PDF
        /// </summary>
        private void Launch(object sender, EventArgs e)
        {
            Logger.Info("Convert images to PDF");
            if (Files.Count == 0)
            {
                MessageBox.Show("No file to convert");
                return;
            }
            var sfd = new SaveFileDialog()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"sample.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var path = new FileInfo(sfd.FileName).Directory.FullName;

            try
            {
                ProgressBar.Value = 0;
                ProgressBar.Visible = true;

                // Convert to PDF and delete image
                for (int i = 0; i < Files.Count; i++)
                {
                    var name = Path.GetFileNameWithoutExtension(Files[i].Path);
                    SaveImageAsPdf(Files[i].Path, $"{Path.Combine(path, name)}.pdf");

                    ProgressBar.Value = (int)((i + 1) * 100.0 / Files.Count);
                    Application.DoEvents();
                }

                MessageBox.Show("Conversion succesful");
                ResetFiles(null, null);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                ProgressBar.Visible = false;
            }
        }

        internal void SaveImageAsPdf(string imageFileName, string pdfFileName, int width = 600, bool deleteImage = false)
        {
            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile(imageFileName))
                {
                    // Calculate new height to keep image ratio
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    // Change PDF Page size to match image
                    page.Width = XUnit.FromPoint(width);
                    page.Height = XUnit.FromPoint(height);

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save(pdfFileName);
            }

            if (deleteImage)
                File.Delete(imageFileName);
        }

        private void ResetFiles(object sender, EventArgs e)
        {
            FlowLayoutFiles.Controls.Clear();
            Files.Clear();
        }
     

        /// <summary>
        /// help: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/walkthrough-performing-a-drag-and-drop-operation-in-windows-forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void HandleDragDrop(object sender, DragEventArgs e)
        {
            FlowLayoutFiles.Controls.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filepath in files)
            {
                var filename = Path.GetFileName(filepath);
                Files.Add(new DopplerFile(filepath, filename));
            }

            foreach (var file in Files)
            {
                Label label = new Label();
                label.Text = file.Name;
                Logger.Info(file.Path);
                FlowLayoutFiles.Controls.Add(label);
            }
        }
    }
}
