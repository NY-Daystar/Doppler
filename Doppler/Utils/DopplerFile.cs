using System.IO;

namespace Doppler.Utils
{
    public class DopplerFile
    {
        public string Name { get; set; }
        public string NameWithoutExt { get; set; }
        public string Path { get; set; }
        public DopplerFile(string path, string filename)
        {
            Name = filename ?? string.Empty;
            Path = path ?? string.Empty;
        }
    }
}
