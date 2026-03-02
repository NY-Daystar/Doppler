using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class VideoTruncater : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, DestinationFolder, PathFfmpeg, StartTime, EndTime;
        private Button SourceButton, DestinationButton, FfMpegButton, TruncaterButton;

        public VideoTruncater(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }
        
        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["textBoxSourceFile2"] is TextBox tb)
                SourceFile = tb;
            SourceFile.Text = Config.SourcePath;

            if (tab.Controls["textBoxDestinationFolder2"] is TextBox tb2)
                DestinationFolder = tb2;
            DestinationFolder.Text = Config.DestinationFolderPath;

            if (tab.Controls["textBoxFfmpegPath2"] is TextBox tb3)
                PathFfmpeg = tb3;
            PathFfmpeg.Text = Config.FfmpegPath;

            if (tab.Controls["startTime"] is TextBox tb4)
                StartTime = tb4;
            StartTime.Text = Config.StartTime;
            StartTime.TextChanged += DefineTime;

            if (tab.Controls["endTime"] is TextBox tb5)
                EndTime = tb5;
            EndTime.Text = Config.StartTime;
            EndTime.TextChanged += DefineTime;

            if (tab.Controls["sourceVideoButton2"] is Button btn)
                SourceButton = btn;
            SourceButton.Click += DefinePath;

            if (tab.Controls["destinationFolderButton2"] is Button btn2)
                DestinationButton = btn2;
            DestinationButton.Click += DefinePath;

            if (tab.Controls["ffmpegButton2"] is Button btn3)
                FfMpegButton = btn3;
            FfMpegButton.Click += DefinePath;

            if (tab.Controls["TruncateVideoButton"] is Button btn5)
                TruncaterButton = btn5;
            TruncaterButton.Click += Launch;
        }

        private void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch video truncater");
            string argsCmd = $"-i \"{Config.SourcePath}\" -ss  {Config.StartTime} -to {Config.EndTime} -c copy \"{Config.DestinationFolderPath}/{Path.GetFileName(Config.SourcePath).Split('.')[0]}-{Config.StartTime.Replace(":", "_")}-{Config.EndTime.Replace(":", "_")}.mp4\"";
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

        private void DefineTime(object sender, EventArgs e)
        {
            if (sender == StartTime)
            {
                Config.StartTime = StartTime.Text;
                Config.Save();
            }
            else if(sender == EndTime)
            {
                Config.EndTime = EndTime.Text;
                Config.Save();
            }
        }
    }
}
