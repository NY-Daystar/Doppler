using Doppler.Utils;
using NLog;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class VideoMerger : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile1, SourceFile2, DestinationFolder, PathFfmpeg;
        private Button SourceButton1, SourceButton2, DestinationButton, FfMpegButton;

        public VideoMerger(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(DopplerForm application)
        {
            SourceFile1 = application.textBoxSourceFile4;
            SourceFile2 = application.textBoxSourceFile5;
            DestinationFolder = application.textBoxDestinationFolder4;
            PathFfmpeg = application.textBoxFfmpegPath4;

            SourceButton1 = application.sourceVideoButton3;
            SourceButton2 = application.sourceVideoButton4;
            DestinationButton = application.destinationFolderButton4;
            FfMpegButton = application.ffmpegButton;

            SourceFile1.Text = Config.SourcePath;
            SourceFile2.Text = Config.MergePath;
            DestinationFolder.Text = Config.DestinationFolderPath;
            PathFfmpeg.Text = Config.FfmpegPath;
        }

        public void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch video merger");
            string tempFile = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            File.WriteAllText(tempFile, $"file '{Config.SourcePath}'\nfile '{Config.MergePath}'");

            string cmd = $"{Config.FfmpegPath} -f concat -safe 0 -i {tempFile} \"{Config.DestinationFolderPath}/output.mp4\"";
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
            if (sender == SourceButton1)
            {
                var filePath = FileManager.SearchFile();
                SourceFile1.Text = filePath;
                Config.SourcePath = filePath;
                Config.Save();
            }
            // To select merge file
            if (sender == SourceButton2)
            {
                var filePath = FileManager.SearchFile();
                SourceFile2.Text = filePath;
                Config.MergePath = filePath;
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
