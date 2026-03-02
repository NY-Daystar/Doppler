using Doppler.Tabs;
using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Doppler
{
    public partial class DopplerView : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Configuration of the application
        /// </summary>
        private readonly DopplerConfig Config;

        /// <summary>
        /// Manager
        /// </summary>
        private FileManager FileManager;
        private ThemeManager ThemeManager;

        /// <summary>
        /// Tabs List functionalities
        /// </summary>
        private ImageToPdfConverter ImageToPdfConverter;
        private PdfCombiner PdfCombiner;
        private Mp3Converter Mp3Converter;
        private VideoMerger VideoMerger;
        private VideoToImagesConverter VideoToImagesConverter;
        private VideoTruncater VideoTruncater;

        public DopplerView()
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
            ThemeManager = new ThemeManager(this, Config);
            VideoToImagesConverter = new VideoToImagesConverter(Config, FileManager);
            VideoTruncater = new VideoTruncater(Config, FileManager);
            Mp3Converter = new Mp3Converter(Config, FileManager);
            VideoMerger = new VideoMerger(Config, FileManager);
            PdfCombiner = new PdfCombiner(Config, FileManager);
            ImageToPdfConverter = new ImageToPdfConverter(Config, FileManager);
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void AttachComponents()
        {
            versionLabel.Text = $"Version: v{Constants.VERSION}";
            FileManager.AttachComponents(this);
            ThemeManager.AttachComponents();
            VideoToImagesConverter.AttachComponents(tabVideoToImage);
            VideoTruncater.AttachComponents(tabTruncateVideo);
            Mp3Converter.AttachComponents(tabConvertMp3);
            VideoMerger.AttachComponents(tabMergeVideos);
            PdfCombiner.AttachComponents(tabPdfCombine);
            ImageToPdfConverter.AttachComponents(tabImageToPdf);
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
            catch (Exception other)
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

        private void ThemeSwitch_Click(object sender, EventArgs e)
        {
            ThemeManager?.Switch(sender, e);
        }
    }
}
