using Doppler.Core.Services;
using System.Configuration;

namespace Doppler.Tests.Services
{
    [TestClass]
    public class VideoServiceTest
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
        [DataRow("FM.mp4", "JS.mp4", "merge.mp4")]
        public void MergeVideo(string filename1, string filename2, string destFile)
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "4-MergeVideos");
            Config.SourcePath = Path.Combine(path, filename1);
            Config.MergePath = Path.Combine(path, filename2);
            Config.DestinationFolderPath = path;

            // Act
            VideoService service = new(Config);
            service.MergeVideo(destFile);

            // Assert
            var output = Path.Combine(path, destFile);
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }

        [TestMethod]
        [DataRow("Oppo.mp4", "image0015.png")]
        public void VideoToImages(string filename, string destFile)
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "1-VideoToImages");
            Config.SourcePath = Path.Combine(path, filename);
            Config.DestinationFolderPath = path;

            // Act
            VideoService service = new(Config);
            service.VideoToImages();

            // Assert
            var output = Path.Combine(path, destFile);
            Assert.IsTrue(File.Exists(output));

            // Clean
            var files = Directory.EnumerateFiles(path, "*.png", SearchOption.AllDirectories);
            files.ToList().ForEach(File.Delete);
        }

        [TestMethod]
        [DataRow("Oppo.mp4", "00:00:10", "00:00:20")]
        public void TruncateVideo(string filename, string start, string end)
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "2-TruncateVideo");
            Config.SourcePath = Path.Combine(path, filename);
            Config.StartTime = start; 
            Config.EndTime = end;
            Config.DestinationFolderPath = path;
            var destFile = $"{filename.Split('.')[0]}-{start.Replace(":", "_")}-{end.Replace(":", "_")}.mp4";

            // Act
            VideoService service = new(Config);
            service.TruncateVideo();

            // Assert
            var output = Path.Combine(path, destFile);
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }
    }
}
