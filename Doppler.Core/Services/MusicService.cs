using Doppler.Core.Utils;
using System;
using System.Diagnostics;
using System.IO;

namespace Doppler.Core.Services
{
    public class MusicService : AbstractService
    {
        public MusicService(DopplerConfig config)
        {
            Configuration = config;
        }

        /// <summary>
        /// Convert mp format mp3 or mp4
        /// </summary>
        public void ConvertToMp(string format)
        {
            var input = ProcessUtil.EscapeArgument(Configuration.SourcePath);

            var outputFileName = Path.GetFileNameWithoutExtension(Configuration.SourcePath);

            var outputPath = Path.Combine(
                Configuration.DestinationFolderPath,
                format.Equals(FormatConversion.MP4, StringComparison.CurrentCultureIgnoreCase)
                    ? $"{outputFileName}.mp4"
                    : $"{outputFileName}.mp3"
            );

            var output = ProcessUtil.EscapeArgument(outputPath);

            string argsCmd;

            if (format.Equals(FormatConversion.MP4, StringComparison.CurrentCultureIgnoreCase))
            {
                argsCmd = $"-i {input} -c copy {output}";
            }
            else
            {
                argsCmd = $"-i {input} -codec:a libmp3lame -qscale:a 2 {output}";
            }

            Logger.Debug($"{Configuration.FfMpegPath} {argsCmd}");

            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = Configuration.FfMpegPath,
                    UseShellExecute = false,
                    Arguments = argsCmd,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                };

                process.Start();
            }
        }
    }
}
