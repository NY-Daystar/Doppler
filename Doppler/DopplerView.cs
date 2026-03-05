using Doppler.Tabs;
using Doppler.Utils;
using NLog;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

// TODO par defaut si on choisit un fichier source on selectionne le meme dossier de resultat
// TODO factoriser les definePath
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

        /// <summary>
        /// Tabs List functionalities
        /// </summary>
        private ImageToPdfConverter ImageToPdfConverter;
        private PdfCombiner PdfCombiner;
        private MpConverter MpConverter;
        private VideoMerger VideoMerger;
        private VideoToImagesConverter VideoToImagesConverter;
        private VideoTruncater VideoTruncater;
        private WatermarkPdf WatermarkPdf;
        private Settings SettignsTab;

        public DopplerView()
        {
            Logger.Debug("Load Configuration");
            Config = DopplerConfig.Get();

            Logger.Debug("Setup components");
            SetupComponents();

            Logger.Debug("Load Components");
            InitializeComponent();

            Logger.Debug("Set culture");
            ApplyTexts();

            Logger.Debug("Load Components");
            AttachComponents();

            tabControl1.SelectedIndex = Config.CurrentTab;

            _ = AutoUpdater.CheckForUpdateAsync();


        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void SetupComponents()
        {
            FileManager = new FileManager();
            VideoToImagesConverter = new VideoToImagesConverter(Config, FileManager);
            VideoTruncater = new VideoTruncater(Config, FileManager);
            MpConverter = new MpConverter(Config, FileManager);
            VideoMerger = new VideoMerger(Config, FileManager);
            PdfCombiner = new PdfCombiner();
            ImageToPdfConverter = new ImageToPdfConverter();
            WatermarkPdf = new WatermarkPdf(Config, FileManager);
            SettignsTab = new Settings(Config, this);
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void AttachComponents()
        {
            versionLabel.Text = $"Version: v{Constants.VERSION}";
            FileManager.AttachComponents(this);
            VideoToImagesConverter.AttachComponents(tabVideoToImage);
            VideoTruncater.AttachComponents(tabTruncateVideo);
            MpConverter.AttachComponents(tabConvertMp);
            VideoMerger.AttachComponents(tabMergeVideos);
            PdfCombiner.AttachComponents(tabPdfCombine);
            ImageToPdfConverter.AttachComponents(tabImageToPdf);
            WatermarkPdf.AttachComponents(tabWatermark);
            SettignsTab.AttachComponents(tabSettings);
        }

        private void SetCulture()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Config.AppLanguage);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Config.AppLanguage);
        }

        public void ApplyTexts()
        {
            SetCulture();

            tabVideoToImage.Text = Language.GetString("UI_Tab1");
            tabTruncateVideo.Text = Language.GetString("UI_Tab2");
            tabConvertMp.Text = Language.GetString("UI_Tab3");
            tabMergeVideos.Text = Language.GetString("UI_Tab4");
            tabPdfCombine.Text = Language.GetString("UI_Tab5");
            tabImageToPdf.Text = Language.GetString("UI_Tab6");
            tabWatermark.Text = Language.GetString("UI_Tab7");
            tabSettings.Text = Language.GetString("UI_Tab8");

            // TODO finir les traductions
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

        private void ShowAbout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("multi-tool to process files (audio/video)");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = tabControl1.SelectedIndex;
            Config.CurrentTab = current;
            Config.Save();
        }
    }
}
