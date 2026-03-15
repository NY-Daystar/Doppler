using Doppler.Core.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.IO;

namespace Doppler.Core.Services
{
    public class VideoService : AbstractService
    {
        public VideoService(DopplerConfig config)
        {
            Configuration = config;
        }

        /// <summary>
        /// Merge 2 videos into one
        /// </summary>
        public void MergeVideo(string destinationFilename = "output.mp4")
        {
            ProcessUtil.ValidatePath(Configuration.SourcePath);
            ProcessUtil.ValidatePath(Configuration.MergePath);
            ProcessUtil.ValidatePath(Configuration.DestinationFolderPath);

            string tempFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".txt");

            string safeSource = Configuration.SourcePath.Replace("'", "'\\''");
            string safeMerge = Configuration.MergePath.Replace("'", "'\\''");

            File.WriteAllText(tempFile, $"file '{safeSource}'\nfile '{safeMerge}'");

            var outputPath = Path.Combine(Configuration.DestinationFolderPath, destinationFilename);

            string argsCmd = $"-f concat -safe 0 -i {ProcessUtil.EscapeArgument(tempFile)} -c copy {ProcessUtil.EscapeArgument(outputPath)}";

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
                process.WaitForExit();
            }

            File.Delete(tempFile);
        }

        /// <summary>
        /// Create all 1s of video one image 
        /// </summary>
        public void VideoToImages()
        {
            ProcessUtil.ValidatePath(Configuration.SourcePath);
            ProcessUtil.ValidatePath(Configuration.DestinationFolderPath);

            var outputPattern = Path.Combine(Configuration.DestinationFolderPath, "image%04d.png");

            string argsCmd = $"-i {ProcessUtil.EscapeArgument(Configuration.SourcePath)} -vf fps=1 {ProcessUtil.EscapeArgument(outputPattern)}";

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

        /// <summary>
        /// Cut video to start and end time
        /// </summary>
        public void TruncateVideo()
        {
            ProcessUtil.ValidatePath(Configuration.SourcePath);
            ProcessUtil.ValidatePath(Configuration.DestinationFolderPath);

            var safeSourcePath = ProcessUtil.EscapeArgument(Configuration.SourcePath);

            if (!ProcessUtil.IsValidTime(Configuration.StartTime)
                || !ProcessUtil.IsValidTime(Configuration.EndTime)
            )
                throw new Exception("Invalid time format");

            var fileName = Path.GetFileNameWithoutExtension(Configuration.SourcePath);

            var outputFile = $"{fileName}-{Configuration.StartTime.Replace(":", "_")}-{Configuration.EndTime.Replace(":", "_")}.mp4";

            var outputPath = ProcessUtil.EscapeArgument(Path.Combine(Configuration.DestinationFolderPath, outputFile));

            string argsCmd =
                $"-i {safeSourcePath} " +
                $"-ss {Configuration.StartTime} -to {Configuration.EndTime} " +
                $"-c copy {outputPath}";

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
                process.WaitForExit();
            }
        }
    }
}
