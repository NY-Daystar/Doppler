using Doppler.Components;
using Doppler.Core.Services;
using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class WatermarkPdf : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, Watermark;
        private Button SourceFileButton, WatermarkButton;

        private const string Output = "watermark";

        public WatermarkPdf(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["textBoxSourceFile6"] is TextBox tb)
                SourceFile = tb;
            SourceFile.Text = Config.SourcePath;

            if (tab.Controls["textBoxWatermark"] is TextBox tb2)
                Watermark = tb2;
            Watermark.TextChanged += DetectChange;

            if (tab.Controls["sourceVideoButton5"] is Button btn)
                SourceFileButton = btn;
            SourceFileButton.Click += DefinePath;

            if (tab.Controls["WatermarkButton"] is Button btn2)
                WatermarkButton = btn2;
            WatermarkButton.Click += Launch;
        }

        private void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch Watermark Pdf merger");

            var sfd = new SaveFileDialog()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"{Output}.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                PdfService service = new PdfService(Config);
                service.WatermarkFile(SourceFile.Text, Watermark.Text, sfd.FileName);

                MessageBox.Show("Watermark succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Watermark : " + ex.Message);
            }

            Process.Start("explorer.exe", new FileInfo(sfd.FileName).Directory.FullName);
        }

        private void DetectChange(object sender, EventArgs e)
        {
            if (sender == Watermark)
                WatermarkButton.Enabled = !string.IsNullOrEmpty(Watermark.Text);
        }

        private void DefinePath(object sender, EventArgs e)
        {
            if (sender == SourceFileButton)
            {
                var filePath = FileManager.SearchFile();
                SourceFile.Text = filePath;
                Config.SourcePath = filePath;
                Config.Save();
            }
        }
    }
}
