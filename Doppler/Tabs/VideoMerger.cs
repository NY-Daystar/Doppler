using Doppler.Utils;
using NLog;
using System;
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
        private Button SourceButton1, SourceButton2, DestinationButton, FfMpegButton, MergerButton;

        public VideoMerger(DopplerConfig config, FileManager fileManager)
        {
            Config = config;
            FileManager = fileManager;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["textBoxSourceFile4"] is TextBox tb)
                SourceFile1 = tb;
            SourceFile1.Text = Config.SourcePath;

            if (tab.Controls["textBoxSourceFile5"] is TextBox tb2)
                SourceFile2 = tb2;
            SourceFile2.Text = Config.MergePath;

            if (tab.Controls["textBoxDestinationFolder4"] is TextBox tb3)
                DestinationFolder = tb3;
            DestinationFolder.Text = Config.DestinationFolderPath;

            if (tab.Controls["textBoxFfmpegPath4"] is TextBox tb4)
                PathFfmpeg = tb4;
            PathFfmpeg.Text = Config.FfmpegPath;

            if (tab.Controls["sourceVideoButton3"] is Button btn)
                SourceButton1 = btn;
            SourceButton1.Click += DefinePath;

            if (tab.Controls["sourceVideoButton4"] is Button btn2)
                SourceButton2 = btn2;
            SourceButton2.Click += DefinePath;

            if (tab.Controls["destinationFolderButton4"] is Button btn3)
                DestinationButton = btn3;
            DestinationButton.Click += DefinePath;

            if (tab.Controls["ffmpegButton4"] is Button btn4)
                FfMpegButton = btn4;
            FfMpegButton.Click += DefinePath;


            if (tab.Controls["MergeVideoButton"] is Button btn5)
                MergerButton = btn5;
            MergerButton.Click += Launch;
        }

        private void Launch(object sender, EventArgs e)
        {
            Logger.Info("Launch video merger");
            string tempFile = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            File.WriteAllText(tempFile, $"file '{Config.SourcePath}'\nfile '{Config.MergePath}'");

            string argsCmd = $"-f concat -safe 0 -i {tempFile} -c copy \"{Path.Combine(Config.DestinationFolderPath, "output.mp4")}\"";
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
