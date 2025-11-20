using Doppler.Utils;
using NLog;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class PdfCombiner : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private FlowLayoutPanel FlowLayoutFiles;
        private ProgressBar ProgressBar;

        private List<DopplerFile> Files = new List<DopplerFile> { };

        private static string MergeFileName = "combinepdf";  

        public PdfCombiner(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(DopplerForm application)
        {
            FlowLayoutFiles = application.flowLayoutFiles;
            ProgressBar = application.progressBar1;
        }

        /// <summary>
        /// Combine PDF
        /// </summary>
        public void Launch(object sender, EventArgs e)
        {
            Logger.Info("Combine PDF");
            if (Files.Count == 0)
            {
                MessageBox.Show("No file to merge");
                return;
            }

            var sfd = new SaveFileDialog()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"{MergeFileName}.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ProgressBar.Value = 0;
                ProgressBar.Visible = true;

                var output = new PdfDocument();

                for (int i = 0; i < Files.Count; i++)
                {
                    PdfDocument input = PdfReader.Open(Files[i].Path, PdfDocumentOpenMode.Import);

                    for (int p = 0; p < input.PageCount; p++)
                    {
                        output.AddPage(input.Pages[p]);
                    }

                    ProgressBar.Value = (int)((i + 1) * 100.0 / Files.Count);
                    Application.DoEvents();
                }

                output.Save(sfd.FileName);
                output.Close();

                MessageBox.Show("Fusion succesful");
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

        public void ResetFiles(object sender, EventArgs e)
        {
            FlowLayoutFiles.Controls.Clear();
            Files.Clear();
        }
     

        /// <summary>
        /// help: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/walkthrough-performing-a-drag-and-drop-operation-in-windows-forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        public void Panel1_DragDrop(object sender, DragEventArgs e)
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

        private class DopplerFile
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public DopplerFile(string path, string filename)
            {
                Name = filename ?? string.Empty;
                Path = path ?? string.Empty;
            }
        }
    }
}
