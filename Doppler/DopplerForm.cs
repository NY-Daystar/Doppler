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
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void SetupComponents()
        {
            FileManager = new FileManager();
            Converter = new ImageConverter(Config, FileManager);
            Truncater = new VideoTruncater(Config, FileManager);
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void AttachComponents()
        {
            versionLabel.Text = $"Version: v{Constants.VERSION}";
            FileManager.AttachComponents(this);
            Converter.AttachComponents(this);
            Truncater.AttachComponents(this);
        }

        private void RedirectToDownload(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.FFMPEG_RELEASES_LINK);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -21_47_46_72_59)
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
                if (noBrowser.ErrorCode == -21_47_46_72_59)
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
