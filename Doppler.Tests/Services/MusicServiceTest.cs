using Doppler.Core.Services;

namespace Doppler.Tests.Services
{
    [TestClass]
    public class MusicServiceTest
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
        [DataRow("LCK.m4a", "mp3", "LCK.mp3")]
        [DataRow("Oppo.webm", "mp4", "Oppo.mp4")]
        public void ConvertToMp(string filename, string format, string result)
        {
            // Arrange
            var path = Path.Combine(TestDirectory, "3-ConvertMp");
            var source = Path.Combine(path, filename);
            Config.DestinationFolderPath = path;
            Config.SourcePath = source;

            // Act
            MusicService service = new(Config);
            service.ConvertToMp(format);

            // Assert
            var output = Path.Combine(path, result);
            Assert.IsTrue(File.Exists(output));

            // Clean
            File.Delete(output);
        }
    }
}
