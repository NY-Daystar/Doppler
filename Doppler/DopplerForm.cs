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
        private readonly DopplerConfig config;

        // README faire un screen de l'application

        public DopplerForm()
        {
            InitializeComponent();
            Logger.Debug("Load application");

            config = DopplerConfig.Get();
            Logger.Debug("Load Configuration");

            SetupComponents();
        }

        /// <summary>
        /// Load data in UI from Configuration
        /// </summary>
        private void SetupComponents()
        {
            textBoxSourceFile.Text = config.SourcePath;
            textBoxDestinationFolder.Text = config.DestinationFolderPath;
            textBoxFfmpegPath.Text = config.FfmpegPath;
        }

        private string BuildFfmpegCommand()
        {
            return $"{config.FfmpegPath} -i {config.SourcePath} -vf fps=1 {config.DestinationFolderPath}/image%04d.png";
        }

        /// <summary>
        /// Build and launch FFMPEG command to generate images
        /// </summary>
        private void Launch(object sender, EventArgs e)
        {
            string cmd = BuildFfmpegCommand();
            Logger.Debug(cmd);

            ProcessStartInfo info = new ProcessStartInfo("cmd.exe")
            {
                Arguments = $"/K {cmd}"
            };
            Process.Start(info);

            Process.Start("explorer.exe", config.DestinationFolderPath);

            MessageBox.Show("Launch FFMPEG");
        }

        private void GetVideoToConvert(object sender, EventArgs e)
        {
            openFileDialogSource.ShowDialog();
            textBoxSourceFile.Text = openFileDialogSource.FileName;
            config.SourcePath = openFileDialogSource.FileName;
            config.Save();
        }

        private void ShowDestingationFolder(object sender, EventArgs e)
        {
            openFileDialogDestination.CheckFileExists = false;
            openFileDialogDestination.ValidateNames = false;

            if (openFileDialogDestination.ShowDialog() == DialogResult.OK)
            {
                string folderPath = System.IO.Path.GetDirectoryName(openFileDialogDestination.FileName);
                textBoxDestinationFolder.Text = folderPath;
                config.DestinationFolderPath = folderPath;
                config.Save();
            }
            else
            {
                MessageBox.Show("Aucun dossier sélectionné.");
            }
        }

        private void GetFFMPEGfile(object sender, EventArgs e)
        {
            openFileDialogFfmpeg.ShowDialog(this);
            textBoxFfmpegPath.Text = openFileDialogFfmpeg.FileName;
            config.FfmpegPath = openFileDialogFfmpeg.FileName;
            config.Save();
        }

        private void RedirectToDownload(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.FFMPEG_RELEASES_LINK);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
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
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
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
