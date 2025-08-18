using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
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
            string cmd = $"{Config.FfmpegPath} -i \"{Config.SourcePath}\" -ss  {Config.StartTime} -to {Config.EndTime} -c copy \"{Config.DestinationFolderPath}/output.mp4\"";
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
