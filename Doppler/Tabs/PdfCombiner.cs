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

        private FlowLayoutPanel FlowLayoutFiles;
        private ProgressBar ProgressBar;
        private Button ResetButton, CombinerButton;

        private List<DopplerFile> Files = new List<DopplerFile> { };

        private const string Output = "combine";

        public PdfCombiner() { }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["flowLayoutFiles"] is FlowLayoutPanel flp)
                FlowLayoutFiles = flp;
            FlowLayoutFiles.DragDrop += HandleDragDrop;
            FlowLayoutFiles.DragEnter += HandleDragEnter;

            if (tab.Controls["progressBar1"] is ProgressBar pn)
                ProgressBar = pn;

            if (tab.Controls["resetFiles"] is Button btn)
                ResetButton = btn;
            ResetButton.Click += ResetFiles;

            if (tab.Controls["PdfCombineButton"] is Button btn2)
                CombinerButton = btn2;
            CombinerButton.Click += Launch;
        }

        /// <summary>
        /// Combine PDF
        /// </summary>
        private void Launch(object sender, EventArgs e)
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
                FileName = $"{Output}.pdf"
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
                MessageBox.Show("Error Combine : " + ex.Message);
            }
            finally
            {
                ProgressBar.Visible = false;
            }
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
