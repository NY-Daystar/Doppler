using Doppler.Tabs;
using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Doppler
{
    public partial class DopplerForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Configuration of the application
        /// </summary>
        private readonly DopplerConfig Config;

        /// <summary>
        /// Tabs List functionalities
        /// </summary>
        private VideoTruncater Truncater;
        private ImageConverter Converter;
        private FileManager FileManager;
        private ThemeManager ThemeManager;
        private Mp3Converter Mp3Converter;
        private VideoMerger VideoMerger;

        public DopplerForm()
        {
            Logger.Debug("Load Configuration");
            Config = DopplerConfig.Get();

            Logger.Debug("Setup components");
            SetupComponents();

            Logger.Debug("Load Components");
            InitializeComponent();

            Logger.Debug("Load Components");
            AttachComponents();

            _ = AutoUpdater.CheckForUpdateAsync();
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void SetupComponents()
        {
            FileManager = new FileManager();
            ThemeManager = new ThemeManager(Config);
            Converter = new ImageConverter(Config, FileManager);
            Truncater = new VideoTruncater(Config, FileManager);
            Mp3Converter = new Mp3Converter(Config, FileManager);
            VideoMerger = new VideoMerger(Config, FileManager);
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void AttachComponents()
        {
            versionLabel.Text = $"Version: v{Constants.VERSION}";
            FileManager.AttachComponents(this);
            ThemeManager.AttachComponents(this);
            Converter.AttachComponents(this);
            Truncater.AttachComponents(this);
            Mp3Converter.AttachComponents(this);
            VideoMerger.AttachComponents(this);
        }

        private void RedirectToDownload(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.FFMPEG_RELEASES_LINK);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2_147_467_259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void LinkToDownload(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.FFMPEG_DOWNLOAD_LINK);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2_147_467_259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void GoToGithub(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Constants.GITHUB_LINK);
        }
    }
}
