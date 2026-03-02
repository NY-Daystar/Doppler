using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class VideoToImagesConverter : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, DestinationFolder, PathFfmpeg;
        private Button SourceButton, DestinationButton, FfMpegButton, ConverterButton;

        public VideoToImagesConverter(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["textBoxSourceFile"] is TextBox tb)
                SourceFile = tb;
            SourceFile.Text = Config.SourcePath;

            if (tab.Controls["textBoxDestinationFolder"] is TextBox tb2)
                DestinationFolder = tb2;
            DestinationFolder.Text = Config.DestinationFolderPath;

            if (tab.Controls["textBoxFfmpegPath"] is TextBox tb3)
                PathFfmpeg = tb3;
            PathFfmpeg.Text = Config.FfmpegPath;
            
            if (tab.Controls["sourceVideoButton"] is Button btn)
                SourceButton = btn;
            SourceButton.Click += DefinePath;
            
            if (tab.Controls["destinationFolderButton"] is Button btn2)
                DestinationButton = btn2;
            DestinationButton.Click += DefinePath;
            
            if (tab.Controls["ffmpegButton"] is Button btn3)
                FfMpegButton = btn3;
            FfMpegButton.Click += DefinePath;

            if (tab.Controls["ConvertImageButton"] is Button btn4)
                ConverterButton = btn4;
            ConverterButton.Click += Launch;
        }

        /// <summary>
        /// Build and launch FFMPEG command to generate images
        /// </summary>
        private void Launch(object sender, EventArgs e)
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

        private void DefinePath(object sender, EventArgs e)
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
