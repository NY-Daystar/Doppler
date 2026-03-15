using Doppler.Core.Services;
using Doppler.Core.Utils;

namespace Doppler.Tests.Services
{
    [TestClass]
    public class PdfServiceTest
    {
        DopplerConfig Config = new();

        string TestDirectory = string.Empty;

        [TestInitialize]
        public void Startup()
        {
            Config = DopplerConfig.Get();
            TestDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\Tests"));
        }

        [TestMethod]
        public void CombinePdf()
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "5-PDFCombine");
            var output = Path.Combine(path, "output.pdf");

            List<DopplerFile> files = [
                new(Path.Combine(path, "1.pdf"), "1.pdf"),
                new(Path.Combine(path, "2.pdf"), "2.pdf"),
                new(Path.Combine(path, "3.pdf"), "3.pdf"),
            ];

            // Act
            PdfService service = new(Config);
            service.CombinePdf(output, files);

            // Assert
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }

        [TestMethod]
        public void WatermarkFile()
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "7-Watermark");
            var source = Path.Combine(path, "TestFile.pdf");
            var output = Path.Combine(path, "output.pdf");

            // Act
            PdfService service = new(Config);
            service.WatermarkFile(source, "WATERMARK", output);

            // Assert
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }

        [TestMethod]
        public void ImageToPdf()
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "6-ImageToPdf");
            var source = Path.Combine(path, "Image1.png");
            var output = Path.Combine(path, "Image1.pdf");

            // Act
            PdfService service = new(Config);
            service.SaveImageAsPdf(source, output);

            // Assert
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }
    }
}
