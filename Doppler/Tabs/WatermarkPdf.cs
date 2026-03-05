using Doppler.Utils;
using NLog;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
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
        private ProgressBar ProgressBar;

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
            SourceFile.TextChanged += DetectChange;

            if (tab.Controls["textBoxWatermark"] is TextBox tb2)
                Watermark = tb2;
            Watermark.TextChanged += DetectChange;

            if (tab.Controls["sourceVideoButton5"] is Button btn)
                SourceFileButton = btn;
            SourceFileButton.Click += DefinePath;

            if (tab.Controls["WatermarkButton"] is Button btn2)
                WatermarkButton = btn2;
            WatermarkButton.Click += Launch;

            if (tab.Controls["progressBar3"] is ProgressBar pn)
                ProgressBar = pn;
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

            PdfDocument document = PdfReader.Open(SourceFile.Text, PdfDocumentOpenMode.Modify);
            const double angle = -45;

            try
            {
                ProgressBar.Value = 0;
                ProgressBar.Visible = true;
                var pageNumber = 0;

                GlobalFontSettings.UseWindowsFontsUnderWindows = true;

                foreach (PdfPage page in document.Pages)
                {
                    XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append);

                    double width = page.Width.Point;
                    double height = page.Height.Point;

                    XFont font = new XFont("Arial", 48, XFontStyleEx.Bold);

                    XBrush brush = new XSolidBrush(XColor.FromArgb(90, 120, 120, 120));

                    DrawWatermark(gfx, Watermark.Text, font, brush, width / 2, height * 0.2, angle);
                    DrawWatermark(gfx, Watermark.Text, font, brush, width / 2, height * 0.5, angle);
                    DrawWatermark(gfx, Watermark.Text, font, brush, width / 2, height * 0.8, angle);

                    ProgressBar.Value = (int)((++pageNumber) * 100.0 / document.PageCount); // TODO a voir
                }

                document.Save(sfd.FileName);

                MessageBox.Show("Watermark succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Watermark : " + ex.Message);
            }

            Process.Start("explorer.exe", new FileInfo(sfd.FileName).Directory.FullName);
        }

        private void DrawWatermark(XGraphics gfx, string text, XFont font, XBrush brush, double x, double y, double angle)
        {
            gfx.Save();

            gfx.TranslateTransform(x, y);
            gfx.RotateTransform(angle);

            gfx.DrawString(
                text,
                font,
                brush,
                new XPoint(0, 0),
                XStringFormats.Center
            );

            gfx.Restore();
        }

        private void DetectChange(object sender, EventArgs e)
        {
            if (sender == WatermarkButton)
                WatermarkButton.Enabled = string.IsNullOrEmpty(Watermark.Text) ? false : true;
            if (sender == SourceFile)
                ProgressBar.Value = 0;
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
