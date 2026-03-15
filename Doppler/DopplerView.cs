using Doppler.Components;
using Doppler.Core.Utils;
using Doppler.Tabs;
using NLog;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

// TODO factoriser les definePath
// TODO par defaut si on choisit un fichier source on selectionne le meme dossier de resultat
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
            PdfCombiner = new PdfCombiner(Config);
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

            label1.Text = Language.GetString("UI_Label1");
            label2.Text = Language.GetString("UI_Label2");
            label3.Text = Language.GetString("L_Location_FFMPEG");
            label4.Text = Language.GetString("UI_Label4");
            label5.Text = Language.GetString("UI_Label5");
            label6.Text = Language.GetString("UI_Label6");
            label7.Text = Language.GetString("UI_Label7");
            label8.Text = Language.GetString("UI_Label8");
            label9.Text = Language.GetString("L_Location_FFMPEG");
            label10.Text = Language.GetString("UI_Label10");
            label11.Text = Language.GetString("UI_Label11");
            label12.Text = Language.GetString("L_Location_FFMPEG");
            label13.Text = Language.GetString("UI_Label13");
            label14.Text = Language.GetString("UI_Label14");
            label15.Text = Language.GetString("L_Location_FFMPEG");
            label16.Text = Language.GetString("UI_Label16");
            label17.Text = Language.GetString("UI_Label17");
            label18.Text = Language.GetString("UI_Label18");
            label19.Text = Language.GetString("UI_Label19");
            label20.Text = Language.GetString("UI_Label20");
            label21.Text = Language.GetString("UI_Label21");

            linkLabel1.Text = Language.GetString("UI_LinkLabel1");

            button3.Text = Language.GetString("L_Download");
            button5.Text = Language.GetString("L_Download");
            button7.Text = Language.GetString("L_Download");
            button9.Text = Language.GetString("L_Download");

            destinationFolderButton.Text = Language.GetString("L_Choose");
            destinationFolderButton2.Text = Language.GetString("L_Choose");
            destinationFolderButton3.Text = Language.GetString("L_Choose");
            destinationFolderButton4.Text = Language.GetString("L_Choose");
            sourceVideoButton.Text = Language.GetString("L_Choose");
            sourceVideoButton2.Text = Language.GetString("L_Choose");
            sourceVideoButton3.Text = Language.GetString("L_Choose");
            sourceVideoButton4.Text = Language.GetString("L_Choose");
            sourceVideoButton5.Text = Language.GetString("L_Choose");
            sourceMusicButton.Text = Language.GetString("L_Choose");
            ffmpegButton.Text = Language.GetString("L_Choose");
            ffmpegButton2.Text = Language.GetString("L_Choose");
            ffmpegButton3.Text = Language.GetString("L_Choose");
            ffmpegButton4.Text = Language.GetString("L_Choose");

            resetFiles.Text = Language.GetString("L_Reset");
            resetFiles2.Text = Language.GetString("L_Reset");

            ConvertImageButton.Text = Language.GetString("UI_ButtonConvertImage");
            ImageToPdfButton.Text = Language.GetString("UI_ButtonImageToPdf");
            MergeVideoButton.Text = Language.GetString("UI_ButtonMergeVideo");
            MpConvertButton.Text = Language.GetString("UI_ButtonMpConvert");
            PdfCombineButton.Text = Language.GetString("UI_ButtonPdfCombine");
            TruncateVideoButton.Text = Language.GetString("UI_ButtonTruncateVideo");
            WatermarkButton.Text = Language.GetString("UI_ButtonWatermark");
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

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = tabControl1.SelectedIndex;
            Config.CurrentTab = current;
            Config.Save();
        }
    }
}
