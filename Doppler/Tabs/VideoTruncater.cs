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
        private Button SourceButton, DestinationButton, FfMpegButton;

        public VideoTruncater(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(DopplerForm application)
        {
            SourceFile = application.textBoxSourceFile2;
            DestinationFolder = application.textBoxDestinationFolder2;
            PathFfmpeg = application.textBoxFfmpegPath2;
            StartTime = application.startTime;
            EndTime = application.endTime;

            SourceButton = application.sourceVideoButton2;
            DestinationButton = application.destinationFolderButton2;
            FfMpegButton = application.ffmpegButton2;

            SourceFile.Text = Config.SourcePath;
            DestinationFolder.Text = Config.DestinationFolderPath;
            PathFfmpeg.Text = Config.FfmpegPath;
            StartTime.Text = Config.StartTime;
            EndTime.Text = Config.EndTime;
        }

        public void Launch(object sender, EventArgs e)
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

        public void DefineTime(object sender, EventArgs e)
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
