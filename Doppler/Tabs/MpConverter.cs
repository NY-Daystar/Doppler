using Doppler.Components;
using Doppler.Core.Services;
using Doppler.Core.Utils;
using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    /// <summary>
    /// Can convert Mp3 or Mp4
    /// </summary>
    public class MpConverter : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;
        private readonly FileManager FileManager;

        private TextBox SourceFile, DestinationFolder, PathFfmpeg;
        private Button SourceButton, DestinationButton, FfMpegButton, ConverterButton;
        private RadioButton Mp3RadioButton, Mp4RadioButton;
        private RadioGroup FormatRadioGroup;

        private string FormatSelected = FormatConversion.MP3;

        public MpConverter(DopplerConfig config, FileManager fileManager)
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
            PathFfmpeg.Text = Config.FfMpegPath;

            if (tab.Controls["sourceMusicButton"] is Button btn)
                SourceButton = btn;
            SourceButton.Click += DefinePath;

            if (tab.Controls["destinationFolderButton3"] is Button btn2)
                DestinationButton = btn2;
            DestinationButton.Click += DefinePath;

            if (tab.Controls["ffmpegButton3"] is Button btn3)
                FfMpegButton = btn3;
            FfMpegButton.Click += DefinePath;

            if (tab.Controls["MpConvertButton"] is Button btn4)
                ConverterButton = btn4;
            ConverterButton.Click += Launch;

            if (tab.Controls["mp3radioButton"] is RadioButton rb)
                Mp3RadioButton = rb;
            Mp3RadioButton.Click += SelectFormat;
            if (tab.Controls["mp4radioButton"] is RadioButton rb2)
                Mp4RadioButton = rb2;
            Mp4RadioButton.Click += SelectFormat;

            FormatRadioGroup = new RadioGroup(new List<RadioButtonExtend>() {
                new RadioButtonExtend(Mp3RadioButton, FormatConversion.MP3),
                new RadioButtonExtend(Mp4RadioButton, FormatConversion.MP4)
            });
        }

        private void Launch(object sender, EventArgs e)
        {
            Logger.Info($"Launch {FormatSelected} Converter");
            MusicService service = new MusicService(Config);
            service.ConvertToMp(FormatSelected);
        }

        private void SelectFormat(object sender, EventArgs e)
        {
            var rbe = FormatRadioGroup.Find((RadioButton)sender);
            FormatSelected = FormatRadioGroup.Handle(rbe);
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
                Config.FfMpegPath = filePath;
                Config.Save();
            }
        }
    }
}
