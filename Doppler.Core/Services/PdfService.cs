using Doppler.Core.Utils;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Doppler.Core.Services
{
    public class PdfService : AbstractService
    {
        /// <summary>
        /// Angle for watermark file
        /// </summary>
        private const int ANGLE = -45;

        public PdfService() { }

        public PdfService(DopplerConfig config)
        {
            Configuration = config;
        }

        /// <summary>
        /// Merge 2 pdf or more files into one
        /// </summary>
        /// <param name="filename">name of final document</param>
        /// <param name="Files">List of files to combine</param>
        public void CombinePdf(string filename, List<DopplerFile> Files)
        {
            var output = new PdfDocument();

            for (int i = 0; i < Files.Count; i++)
            {
                PdfDocument input = PdfReader.Open(Files[i].Path, PdfDocumentOpenMode.Import);

                for (int p = 0; p < input.PageCount; p++)
                {
                    output.AddPage(input.Pages[p]);
                }
            }

            output.Save(filename);
            output.Close();
        }

        /// <summary>
        /// Set a watermark on pdf file
        /// </summary>
        /// <param name="sourcePath">original file</param>
        /// <param name="text">text watermarked</param>
        /// <param name="outputPath">file watermarked</param>
        public void WatermarkFile(string sourcePath, string text, string outputPath)
        {
            PdfDocument document = PdfReader.Open(sourcePath, PdfDocumentOpenMode.Modify);

            GlobalFontSettings.UseWindowsFontsUnderWindows = true;

            foreach (PdfPage page in document.Pages)
            {
                XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append);

                double width = page.Width.Point;
                double height = page.Height.Point;

                XFont font = new XFont("Arial", 48, XFontStyleEx.Bold);

                XBrush brush = new XSolidBrush(XColor.FromArgb(90, 120, 120, 120));

                DrawWatermark(gfx, text, font, brush, width / 2, height * 0.2, ANGLE);
                DrawWatermark(gfx, text, font, brush, width / 2, height * 0.5, ANGLE);
                DrawWatermark(gfx, text, font, brush, width / 2, height * 0.8, ANGLE);
            }

            document.Save(outputPath);
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

        /// <summary>
        /// Convert png or jpeg file into pdf file
        /// </summary>
        public void SaveImageAsPdf(string imageFilePath, string pdfFilePath, int width = 600)
        {
            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile(imageFilePath))
                {
                    // Calculate new height to keep image ratio
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    // Change PDF Page size to match image
                    page.Width = XUnit.FromPoint(width);
                    page.Height = XUnit.FromPoint(height);

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save(pdfFilePath);
            }
        }
    }
}
