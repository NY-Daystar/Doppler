using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class Mp3Converter : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, DestinationFolder, PathFfmpeg;
        private Button SourceButton, DestinationButton, FfMpegButton;

        public Mp3Converter(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(DopplerForm application)
        {
            SourceFile = application.textBoxSourceFile3;
            DestinationFolder = application.textBoxDestinationFolder3;
            PathFfmpeg = application.textBoxFfmpegPath3;

            SourceButton = application.sourceMusicButton;
            DestinationButton = application.destinationFolderButton3;
            FfMpegButton = application.ffmpegButton3;

            SourceFile.Text = Config.SourcePath;
            DestinationFolder.Text = Config.DestinationFolderPath;
            PathFfmpeg.Text = Config.FfmpegPath;
        }

        public void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch Mp3 Converter");
            string cmd = $"{Config.FfmpegPath} -i \"{Config.SourcePath}\" -codec:a libmp3lame -qscale:a 2 \"{Config.DestinationFolderPath}/{Path.GetFileName(Config.SourcePath).Split('.')[0]}.mp3\"";
            Logger.Debug(cmd);

            ProcessStartInfo info = new ProcessStartInfo("cmd.exe")
            {
                Arguments = $"/K {cmd}"
            };
            Process.Start(info);

            Process.Start("explorer.exe", Config.DestinationFolderPath);

            MessageBox.Show("Launch FFMPEG");
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
