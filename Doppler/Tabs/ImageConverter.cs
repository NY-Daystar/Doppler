using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class ImageConverter : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, DestinationFolder, PathFfmpeg;
        private Button SourceButton, DestinationButton, FfMpegButton;

        public ImageConverter(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(DopplerForm application)
        {
            SourceFile = application.textBoxSourceFile;
            DestinationFolder = application.textBoxDestinationFolder;
            PathFfmpeg = application.textBoxFfmpegPath;

            SourceButton = application.sourceVideoButton;
            DestinationButton = application.destinationFolderButton;
            FfMpegButton = application.ffmpegButton;

            SourceFile.Text = Config.SourcePath;
            DestinationFolder.Text = Config.DestinationFolderPath;
            PathFfmpeg.Text = Config.FfmpegPath;
        }

        /// <summary>
        /// Build and launch FFMPEG command to generate images
        /// </summary>
        public void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch image Converter");

            string argsCmd = $"-i \"{Config.SourcePath}\" -vf fps=1 \"{Config.DestinationFolderPath}/image%04d.png\"";
            Logger.Debug($"{Config.FfmpegPath} {argsCmd}");

            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = Config.FfmpegPath,
                    UseShellExecute = true,
                    Arguments = argsCmd,
                };
                process.Start();
            }

            Process.Start("explorer.exe", Config.DestinationFolderPath);
        }

        public void DefinePath(object sender, EventArgs e)
        {
            // To select source file
            if (sender == SourceButton)
            {
                var filePath = FileManager.SearchFile();
                SourceFile.Text = filePath;
                Config.SourcePath = filePath;
                Config.Save();
            }
            // To select folder path
            else if (sender == DestinationButton)
            {
                var folderPath = FileManager.SearchFolder();
                DestinationFolder.Text = folderPath;
                Config.DestinationFolderPath = folderPath;
                Config.Save();
            }
            // To select config FFMPEG
            else if (sender == FfMpegButton)
            {
                var filePath = FileManager.SearchFile();
                PathFfmpeg.Text = filePath;
                Config.FfmpegPath = filePath;
                Config.Save();
            }
        }
    }
}
