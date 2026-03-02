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
        private Button SourceButton, DestinationButton, FfMpegButton, ConverterButton;

        public Mp3Converter(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["textBoxSourceFile3"] is TextBox tb)
                SourceFile = tb;
            SourceFile.Text = Config.SourcePath;

            if (tab.Controls["textBoxDestinationFolder3"] is TextBox tb2)
                DestinationFolder = tb2;
            DestinationFolder.Text = Config.DestinationFolderPath;

            if (tab.Controls["textBoxFfmpegPath3"] is TextBox tb3)
                PathFfmpeg = tb3;
            PathFfmpeg.Text = Config.FfmpegPath;

            if (tab.Controls["sourceMusicButton"] is Button btn)
                SourceButton = btn;
            SourceButton.Click += DefinePath;

            if (tab.Controls["destinationFolderButton3"] is Button btn2)
                DestinationButton = btn2;
            DestinationButton.Click += DefinePath;

            if (tab.Controls["ffmpegButton3"] is Button btn3)
                FfMpegButton = btn3;
            FfMpegButton.Click += DefinePath;

            if (tab.Controls["Mp3ConvertButton"] is Button btn4)
                ConverterButton = btn4;
            ConverterButton.Click += Launch;
        }

        private void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch Mp3 Converter");
            string argsCmd = $"-i \"{Config.SourcePath}\" -codec:a libmp3lame -qscale:a 2 \"{Config.DestinationFolderPath}/{Path.GetFileName(Config.SourcePath).Split('.')[0]}.mp3\"";
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
