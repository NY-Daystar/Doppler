using Doppler.Core.Services;
using Doppler.Core.Utils;
using NLog;
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

        private FlowLayoutPanel FlowLayoutFiles;
        private ProgressBar ProgressBar;
        private Button ResetButton, CombinerButton;

        private readonly List<DopplerFile> Files = new List<DopplerFile> { };

        private const string Output = "combine";

        public PdfCombiner(DopplerConfig config)
        {
            Config = config;
        }

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

            var service = new PdfService(Config);

            ProgressBar.Value = 0;
            ProgressBar.Visible = true;

            try
            {
                service.CombinePdf(sfd.FileName, Files);
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
                Label label = new Label
                {
                    Text = file.Name
                };
                Logger.Info(file.Path);
                FlowLayoutFiles.Controls.Add(label);
            }
        }
    }
}
