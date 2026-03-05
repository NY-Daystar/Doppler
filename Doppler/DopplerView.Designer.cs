using Doppler;

namespace Doppler
{
    partial class DopplerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DopplerView));
            this.versionLabel = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDestination = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFfmpeg = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVideoToImage = new System.Windows.Forms.TabPage();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sourceVideoButton = new System.Windows.Forms.Button();
            this.textBoxFfmpegPath = new System.Windows.Forms.TextBox();
            this.ffmpegButton = new System.Windows.Forms.Button();
            this.ConvertImageButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.destinationFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTruncateVideo = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TruncateVideoButton = new System.Windows.Forms.Button();
            this.ffmpegButton2 = new System.Windows.Forms.Button();
            this.textBoxFfmpegPath2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.destinationFolderButton2 = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sourceVideoButton2 = new System.Windows.Forms.Button();
            this.textBoxSourceFile2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabConvertMp = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.mp4radioButton = new System.Windows.Forms.RadioButton();
            this.mp3radioButton = new System.Windows.Forms.RadioButton();
            this.MpConvertButton = new System.Windows.Forms.Button();
            this.ffmpegButton3 = new System.Windows.Forms.Button();
            this.textBoxFfmpegPath3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.destinationFolderButton3 = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sourceMusicButton = new System.Windows.Forms.Button();
            this.textBoxSourceFile3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabMergeVideos = new System.Windows.Forms.TabPage();
            this.sourceVideoButton4 = new System.Windows.Forms.Button();
            this.textBoxSourceFile5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MergeVideoButton = new System.Windows.Forms.Button();
            this.ffmpegButton4 = new System.Windows.Forms.Button();
            this.textBoxFfmpegPath4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.destinationFolderButton4 = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sourceVideoButton3 = new System.Windows.Forms.Button();
            this.textBoxSourceFile4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPdfCombine = new System.Windows.Forms.TabPage();
            this.resetFiles = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.PdfCombineButton = new System.Windows.Forms.Button();
            this.tabImageToPdf = new System.Windows.Forms.TabPage();
            this.resetFiles2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutFiles2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageToPdfButton = new System.Windows.Forms.Button();
            this.tabWatermark = new System.Windows.Forms.TabPage();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label21 = new System.Windows.Forms.Label();
            this.WatermarkButton = new System.Windows.Forms.Button();
            this.textBoxWatermark = new System.Windows.Forms.TextBox();
            this.sourceVideoButton5 = new System.Windows.Forms.Button();
            this.textBoxSourceFile6 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.languageCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabVideoToImage.SuspendLayout();
            this.tabTruncateVideo.SuspendLayout();
            this.tabConvertMp.SuspendLayout();
            this.tabMergeVideos.SuspendLayout();
            this.tabPdfCombine.SuspendLayout();
            this.tabImageToPdf.SuspendLayout();
            this.tabWatermark.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(947, 11);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(129, 16);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version: {VERSION}";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(947, 41);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github project";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToGithub);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVideoToImage);
            this.tabControl1.Controls.Add(this.tabTruncateVideo);
            this.tabControl1.Controls.Add(this.tabConvertMp);
            this.tabControl1.Controls.Add(this.tabMergeVideos);
            this.tabControl1.Controls.Add(this.tabPdfCombine);
            this.tabControl1.Controls.Add(this.tabImageToPdf);
            this.tabControl1.Controls.Add(this.tabWatermark);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(16, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 486);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabVideoToImage
            // 
            this.tabVideoToImage.BackColor = System.Drawing.SystemColors.Control;
            this.tabVideoToImage.Controls.Add(this.textBoxSourceFile);
            this.tabVideoToImage.Controls.Add(this.label2);
            this.tabVideoToImage.Controls.Add(this.label6);
            this.tabVideoToImage.Controls.Add(this.sourceVideoButton);
            this.tabVideoToImage.Controls.Add(this.textBoxFfmpegPath);
            this.tabVideoToImage.Controls.Add(this.ffmpegButton);
            this.tabVideoToImage.Controls.Add(this.ConvertImageButton);
            this.tabVideoToImage.Controls.Add(this.button5);
            this.tabVideoToImage.Controls.Add(this.label5);
            this.tabVideoToImage.Controls.Add(this.button4);
            this.tabVideoToImage.Controls.Add(this.textBoxDestinationFolder);
            this.tabVideoToImage.Controls.Add(this.destinationFolderButton);
            this.tabVideoToImage.Controls.Add(this.label3);
            this.tabVideoToImage.Location = new System.Drawing.Point(4, 25);
            this.tabVideoToImage.Margin = new System.Windows.Forms.Padding(4);
            this.tabVideoToImage.Name = "tabVideoToImage";
            this.tabVideoToImage.Padding = new System.Windows.Forms.Padding(4);
            this.tabVideoToImage.Size = new System.Drawing.Size(1019, 457);
            this.tabVideoToImage.TabIndex = 0;
            this.tabVideoToImage.Text = "VideoToImages";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(73, 74);
            this.textBoxSourceFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose a video";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tool to convert video into images";
            // 
            // sourceVideoButton
            // 
            this.sourceVideoButton.Location = new System.Drawing.Point(587, 70);
            this.sourceVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.sourceVideoButton.Name = "sourceVideoButton";
            this.sourceVideoButton.Size = new System.Drawing.Size(100, 28);
            this.sourceVideoButton.TabIndex = 6;
            this.sourceVideoButton.Text = "Choose";
            this.sourceVideoButton.UseVisualStyleBackColor = true;
            // 
            // textBoxFfmpegPath
            // 
            this.textBoxFfmpegPath.Location = new System.Drawing.Point(75, 284);
            this.textBoxFfmpegPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFfmpegPath.Name = "textBoxFfmpegPath";
            this.textBoxFfmpegPath.Size = new System.Drawing.Size(504, 22);
            this.textBoxFfmpegPath.TabIndex = 10;
            // 
            // ffmpegButton
            // 
            this.ffmpegButton.Location = new System.Drawing.Point(588, 281);
            this.ffmpegButton.Margin = new System.Windows.Forms.Padding(4);
            this.ffmpegButton.Name = "ffmpegButton";
            this.ffmpegButton.Size = new System.Drawing.Size(100, 28);
            this.ffmpegButton.TabIndex = 11;
            this.ffmpegButton.Text = "Choose";
            this.ffmpegButton.UseVisualStyleBackColor = true;
            // 
            // ConvertImageButton
            // 
            this.ConvertImageButton.Location = new System.Drawing.Point(407, 389);
            this.ConvertImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertImageButton.Name = "ConvertImageButton";
            this.ConvertImageButton.Size = new System.Drawing.Size(177, 28);
            this.ConvertImageButton.TabIndex = 0;
            this.ConvertImageButton.Text = "Convert into images";
            this.ConvertImageButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 249);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 28);
            this.button5.TabIndex = 13;
            this.button5.Text = "Download";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select the folder to save images";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Location = new System.Drawing.Point(236, 249);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(73, 165);
            this.textBoxDestinationFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(505, 22);
            this.textBoxDestinationFolder.TabIndex = 3;
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(587, 165);
            this.destinationFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(100, 28);
            this.destinationFolderButton.TabIndex = 7;
            this.destinationFolderButton.Text = "Choose";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location of FFMPEG.exe";
            // 
            // tabTruncateVideo
            // 
            this.tabTruncateVideo.BackColor = System.Drawing.SystemColors.Control;
            this.tabTruncateVideo.Controls.Add(this.label11);
            this.tabTruncateVideo.Controls.Add(this.endTime);
            this.tabTruncateVideo.Controls.Add(this.startTime);
            this.tabTruncateVideo.Controls.Add(this.label10);
            this.tabTruncateVideo.Controls.Add(this.label1);
            this.tabTruncateVideo.Controls.Add(this.TruncateVideoButton);
            this.tabTruncateVideo.Controls.Add(this.ffmpegButton2);
            this.tabTruncateVideo.Controls.Add(this.textBoxFfmpegPath2);
            this.tabTruncateVideo.Controls.Add(this.button9);
            this.tabTruncateVideo.Controls.Add(this.button8);
            this.tabTruncateVideo.Controls.Add(this.label9);
            this.tabTruncateVideo.Controls.Add(this.destinationFolderButton2);
            this.tabTruncateVideo.Controls.Add(this.textBoxDestinationFolder2);
            this.tabTruncateVideo.Controls.Add(this.label8);
            this.tabTruncateVideo.Controls.Add(this.sourceVideoButton2);
            this.tabTruncateVideo.Controls.Add(this.textBoxSourceFile2);
            this.tabTruncateVideo.Controls.Add(this.label7);
            this.tabTruncateVideo.Location = new System.Drawing.Point(4, 25);
            this.tabTruncateVideo.Margin = new System.Windows.Forms.Padding(4);
            this.tabTruncateVideo.Name = "tabTruncateVideo";
            this.tabTruncateVideo.Padding = new System.Windows.Forms.Padding(4);
            this.tabTruncateVideo.Size = new System.Drawing.Size(1019, 457);
            this.tabTruncateVideo.TabIndex = 1;
            this.tabTruncateVideo.Text = "TruncateVideo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(347, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(345, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tool to truncate video with start and end time";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(432, 177);
            this.endTime.Margin = new System.Windows.Forms.Padding(4);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(145, 22);
            this.endTime.TabIndex = 22;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(145, 177);
            this.startTime.Margin = new System.Windows.Forms.Padding(4);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(155, 22);
            this.startTime.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "End time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Start time";
            // 
            // TruncateVideoButton
            // 
            this.TruncateVideoButton.Location = new System.Drawing.Point(364, 382);
            this.TruncateVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.TruncateVideoButton.Name = "TruncateVideoButton";
            this.TruncateVideoButton.Size = new System.Drawing.Size(177, 28);
            this.TruncateVideoButton.TabIndex = 18;
            this.TruncateVideoButton.Text = "Truncate the video";
            this.TruncateVideoButton.UseVisualStyleBackColor = true;
            // 
            // ffmpegButton2
            // 
            this.ffmpegButton2.Location = new System.Drawing.Point(588, 262);
            this.ffmpegButton2.Margin = new System.Windows.Forms.Padding(4);
            this.ffmpegButton2.Name = "ffmpegButton2";
            this.ffmpegButton2.Size = new System.Drawing.Size(100, 28);
            this.ffmpegButton2.TabIndex = 17;
            this.ffmpegButton2.Text = "Choose";
            this.ffmpegButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxFfmpegPath2
            // 
            this.textBoxFfmpegPath2.Location = new System.Drawing.Point(73, 262);
            this.textBoxFfmpegPath2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFfmpegPath2.Name = "textBoxFfmpegPath2";
            this.textBoxFfmpegPath2.Size = new System.Drawing.Size(504, 22);
            this.textBoxFfmpegPath2.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(284, 233);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 28);
            this.button9.TabIndex = 15;
            this.button9.Text = "Download";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Help;
            this.button8.Location = new System.Drawing.Point(245, 233);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 28);
            this.button8.TabIndex = 14;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton2
            // 
            this.destinationFolderButton2.Location = new System.Drawing.Point(588, 132);
            this.destinationFolderButton2.Margin = new System.Windows.Forms.Padding(4);
            this.destinationFolderButton2.Name = "destinationFolderButton2";
            this.destinationFolderButton2.Size = new System.Drawing.Size(100, 28);
            this.destinationFolderButton2.TabIndex = 12;
            this.destinationFolderButton2.Text = "Choose";
            this.destinationFolderButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationFolder2
            // 
            this.textBoxDestinationFolder2.Location = new System.Drawing.Point(72, 134);
            this.textBoxDestinationFolder2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestinationFolder2.Name = "textBoxDestinationFolder2";
            this.textBoxDestinationFolder2.Size = new System.Drawing.Size(505, 22);
            this.textBoxDestinationFolder2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select the folder to save new video";
            // 
            // sourceVideoButton2
            // 
            this.sourceVideoButton2.Location = new System.Drawing.Point(587, 75);
            this.sourceVideoButton2.Margin = new System.Windows.Forms.Padding(4);
            this.sourceVideoButton2.Name = "sourceVideoButton2";
            this.sourceVideoButton2.Size = new System.Drawing.Size(100, 28);
            this.sourceVideoButton2.TabIndex = 7;
            this.sourceVideoButton2.Text = "Choose";
            this.sourceVideoButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFile2
            // 
            this.textBoxSourceFile2.Location = new System.Drawing.Point(73, 75);
            this.textBoxSourceFile2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile2.Name = "textBoxSourceFile2";
            this.textBoxSourceFile2.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose a video";
            // 
            // tabConvertMp
            // 
            this.tabConvertMp.BackColor = System.Drawing.SystemColors.Control;
            this.tabConvertMp.Controls.Add(this.label19);
            this.tabConvertMp.Controls.Add(this.mp4radioButton);
            this.tabConvertMp.Controls.Add(this.mp3radioButton);
            this.tabConvertMp.Controls.Add(this.MpConvertButton);
            this.tabConvertMp.Controls.Add(this.ffmpegButton3);
            this.tabConvertMp.Controls.Add(this.textBoxFfmpegPath3);
            this.tabConvertMp.Controls.Add(this.button3);
            this.tabConvertMp.Controls.Add(this.button6);
            this.tabConvertMp.Controls.Add(this.label12);
            this.tabConvertMp.Controls.Add(this.destinationFolderButton3);
            this.tabConvertMp.Controls.Add(this.textBoxDestinationFolder3);
            this.tabConvertMp.Controls.Add(this.label13);
            this.tabConvertMp.Controls.Add(this.sourceMusicButton);
            this.tabConvertMp.Controls.Add(this.textBoxSourceFile3);
            this.tabConvertMp.Controls.Add(this.label14);
            this.tabConvertMp.Location = new System.Drawing.Point(4, 25);
            this.tabConvertMp.Margin = new System.Windows.Forms.Padding(4);
            this.tabConvertMp.Name = "tabConvertMp";
            this.tabConvertMp.Padding = new System.Windows.Forms.Padding(4);
            this.tabConvertMp.Size = new System.Drawing.Size(1019, 457);
            this.tabConvertMp.TabIndex = 2;
            this.tabConvertMp.Text = "ConvertMp3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(73, 183);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "Convert into";
            // 
            // mp4radioButton
            // 
            this.mp4radioButton.AutoSize = true;
            this.mp4radioButton.Location = new System.Drawing.Point(276, 182);
            this.mp4radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.mp4radioButton.Name = "mp4radioButton";
            this.mp4radioButton.Size = new System.Drawing.Size(55, 20);
            this.mp4radioButton.TabIndex = 32;
            this.mp4radioButton.Text = "MP4";
            this.mp4radioButton.UseVisualStyleBackColor = true;
            // 
            // mp3radioButton
            // 
            this.mp3radioButton.AutoSize = true;
            this.mp3radioButton.Checked = true;
            this.mp3radioButton.Location = new System.Drawing.Point(189, 182);
            this.mp3radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.mp3radioButton.Name = "mp3radioButton";
            this.mp3radioButton.Size = new System.Drawing.Size(55, 20);
            this.mp3radioButton.TabIndex = 31;
            this.mp3radioButton.TabStop = true;
            this.mp3radioButton.Text = "MP3";
            this.mp3radioButton.UseVisualStyleBackColor = true;
            // 
            // MpConvertButton
            // 
            this.MpConvertButton.Location = new System.Drawing.Point(368, 382);
            this.MpConvertButton.Margin = new System.Windows.Forms.Padding(4);
            this.MpConvertButton.Name = "MpConvertButton";
            this.MpConvertButton.Size = new System.Drawing.Size(177, 28);
            this.MpConvertButton.TabIndex = 30;
            this.MpConvertButton.Text = "Convert";
            this.MpConvertButton.UseVisualStyleBackColor = true;
            // 
            // ffmpegButton3
            // 
            this.ffmpegButton3.Location = new System.Drawing.Point(592, 262);
            this.ffmpegButton3.Margin = new System.Windows.Forms.Padding(4);
            this.ffmpegButton3.Name = "ffmpegButton3";
            this.ffmpegButton3.Size = new System.Drawing.Size(100, 28);
            this.ffmpegButton3.TabIndex = 29;
            this.ffmpegButton3.Text = "Choose";
            this.ffmpegButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxFfmpegPath3
            // 
            this.textBoxFfmpegPath3.Location = new System.Drawing.Point(77, 262);
            this.textBoxFfmpegPath3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFfmpegPath3.Name = "textBoxFfmpegPath3";
            this.textBoxFfmpegPath3.Size = new System.Drawing.Size(504, 22);
            this.textBoxFfmpegPath3.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 233);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 28);
            this.button3.TabIndex = 27;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Help;
            this.button6.Location = new System.Drawing.Point(249, 233);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 28);
            this.button6.TabIndex = 26;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 239);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton3
            // 
            this.destinationFolderButton3.Location = new System.Drawing.Point(592, 132);
            this.destinationFolderButton3.Margin = new System.Windows.Forms.Padding(4);
            this.destinationFolderButton3.Name = "destinationFolderButton3";
            this.destinationFolderButton3.Size = new System.Drawing.Size(100, 28);
            this.destinationFolderButton3.TabIndex = 24;
            this.destinationFolderButton3.Text = "Choose";
            this.destinationFolderButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationFolder3
            // 
            this.textBoxDestinationFolder3.Location = new System.Drawing.Point(76, 134);
            this.textBoxDestinationFolder3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestinationFolder3.Name = "textBoxDestinationFolder3";
            this.textBoxDestinationFolder3.Size = new System.Drawing.Size(505, 22);
            this.textBoxDestinationFolder3.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Select the folder to save mp3 music";
            // 
            // sourceMusicButton
            // 
            this.sourceMusicButton.Location = new System.Drawing.Point(591, 75);
            this.sourceMusicButton.Margin = new System.Windows.Forms.Padding(4);
            this.sourceMusicButton.Name = "sourceMusicButton";
            this.sourceMusicButton.Size = new System.Drawing.Size(100, 28);
            this.sourceMusicButton.TabIndex = 21;
            this.sourceMusicButton.Text = "Choose";
            this.sourceMusicButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFile3
            // 
            this.textBoxSourceFile3.Location = new System.Drawing.Point(77, 75);
            this.textBoxSourceFile3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile3.Name = "textBoxSourceFile3";
            this.textBoxSourceFile3.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile3.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Choose a music (mp4, ogg, m4a, avi, etc...)";
            // 
            // tabMergeVideos
            // 
            this.tabMergeVideos.BackColor = System.Drawing.SystemColors.Control;
            this.tabMergeVideos.Controls.Add(this.sourceVideoButton4);
            this.tabMergeVideos.Controls.Add(this.textBoxSourceFile5);
            this.tabMergeVideos.Controls.Add(this.label18);
            this.tabMergeVideos.Controls.Add(this.MergeVideoButton);
            this.tabMergeVideos.Controls.Add(this.ffmpegButton4);
            this.tabMergeVideos.Controls.Add(this.textBoxFfmpegPath4);
            this.tabMergeVideos.Controls.Add(this.button7);
            this.tabMergeVideos.Controls.Add(this.button10);
            this.tabMergeVideos.Controls.Add(this.label15);
            this.tabMergeVideos.Controls.Add(this.destinationFolderButton4);
            this.tabMergeVideos.Controls.Add(this.textBoxDestinationFolder4);
            this.tabMergeVideos.Controls.Add(this.label16);
            this.tabMergeVideos.Controls.Add(this.sourceVideoButton3);
            this.tabMergeVideos.Controls.Add(this.textBoxSourceFile4);
            this.tabMergeVideos.Controls.Add(this.label17);
            this.tabMergeVideos.Location = new System.Drawing.Point(4, 25);
            this.tabMergeVideos.Margin = new System.Windows.Forms.Padding(4);
            this.tabMergeVideos.Name = "tabMergeVideos";
            this.tabMergeVideos.Padding = new System.Windows.Forms.Padding(4);
            this.tabMergeVideos.Size = new System.Drawing.Size(1019, 457);
            this.tabMergeVideos.TabIndex = 3;
            this.tabMergeVideos.Text = "MergeVideos";
            // 
            // sourceVideoButton4
            // 
            this.sourceVideoButton4.Location = new System.Drawing.Point(609, 144);
            this.sourceVideoButton4.Margin = new System.Windows.Forms.Padding(4);
            this.sourceVideoButton4.Name = "sourceVideoButton4";
            this.sourceVideoButton4.Size = new System.Drawing.Size(100, 28);
            this.sourceVideoButton4.TabIndex = 45;
            this.sourceVideoButton4.Text = "Choose";
            this.sourceVideoButton4.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFile5
            // 
            this.textBoxSourceFile5.Location = new System.Drawing.Point(96, 144);
            this.textBoxSourceFile5.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile5.Name = "textBoxSourceFile5";
            this.textBoxSourceFile5.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile5.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(92, 124);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "Choose second video";
            // 
            // MergeVideoButton
            // 
            this.MergeVideoButton.Location = new System.Drawing.Point(388, 396);
            this.MergeVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.MergeVideoButton.Name = "MergeVideoButton";
            this.MergeVideoButton.Size = new System.Drawing.Size(177, 28);
            this.MergeVideoButton.TabIndex = 42;
            this.MergeVideoButton.Text = "Merge videos";
            this.MergeVideoButton.UseVisualStyleBackColor = true;
            // 
            // ffmpegButton4
            // 
            this.ffmpegButton4.Location = new System.Drawing.Point(612, 277);
            this.ffmpegButton4.Margin = new System.Windows.Forms.Padding(4);
            this.ffmpegButton4.Name = "ffmpegButton4";
            this.ffmpegButton4.Size = new System.Drawing.Size(100, 28);
            this.ffmpegButton4.TabIndex = 41;
            this.ffmpegButton4.Text = "Choose";
            this.ffmpegButton4.UseVisualStyleBackColor = true;
            // 
            // textBoxFfmpegPath4
            // 
            this.textBoxFfmpegPath4.Location = new System.Drawing.Point(97, 277);
            this.textBoxFfmpegPath4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFfmpegPath4.Name = "textBoxFfmpegPath4";
            this.textBoxFfmpegPath4.Size = new System.Drawing.Size(504, 22);
            this.textBoxFfmpegPath4.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(308, 247);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 28);
            this.button7.TabIndex = 39;
            this.button7.Text = "Download";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Help;
            this.button10.Location = new System.Drawing.Point(269, 247);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 28);
            this.button10.TabIndex = 38;
            this.button10.Text = "?";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 254);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton4
            // 
            this.destinationFolderButton4.Location = new System.Drawing.Point(611, 213);
            this.destinationFolderButton4.Margin = new System.Windows.Forms.Padding(4);
            this.destinationFolderButton4.Name = "destinationFolderButton4";
            this.destinationFolderButton4.Size = new System.Drawing.Size(100, 28);
            this.destinationFolderButton4.TabIndex = 36;
            this.destinationFolderButton4.Text = "Choose";
            this.destinationFolderButton4.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationFolder4
            // 
            this.textBoxDestinationFolder4.Location = new System.Drawing.Point(96, 215);
            this.textBoxDestinationFolder4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestinationFolder4.Name = "textBoxDestinationFolder4";
            this.textBoxDestinationFolder4.Size = new System.Drawing.Size(505, 22);
            this.textBoxDestinationFolder4.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 196);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Select the folder to save mp3 music";
            // 
            // sourceVideoButton3
            // 
            this.sourceVideoButton3.Location = new System.Drawing.Point(611, 90);
            this.sourceVideoButton3.Margin = new System.Windows.Forms.Padding(4);
            this.sourceVideoButton3.Name = "sourceVideoButton3";
            this.sourceVideoButton3.Size = new System.Drawing.Size(100, 28);
            this.sourceVideoButton3.TabIndex = 33;
            this.sourceVideoButton3.Text = "Choose";
            this.sourceVideoButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFile4
            // 
            this.textBoxSourceFile4.Location = new System.Drawing.Point(97, 90);
            this.textBoxSourceFile4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile4.Name = "textBoxSourceFile4";
            this.textBoxSourceFile4.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile4.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(93, 70);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "Choose first video";
            // 
            // tabPdfCombine
            // 
            this.tabPdfCombine.BackColor = System.Drawing.SystemColors.Control;
            this.tabPdfCombine.Controls.Add(this.resetFiles);
            this.tabPdfCombine.Controls.Add(this.progressBar1);
            this.tabPdfCombine.Controls.Add(this.flowLayoutFiles);
            this.tabPdfCombine.Controls.Add(this.PdfCombineButton);
            this.tabPdfCombine.Location = new System.Drawing.Point(4, 25);
            this.tabPdfCombine.Margin = new System.Windows.Forms.Padding(4);
            this.tabPdfCombine.Name = "tabPdfCombine";
            this.tabPdfCombine.Padding = new System.Windows.Forms.Padding(4);
            this.tabPdfCombine.Size = new System.Drawing.Size(1019, 457);
            this.tabPdfCombine.TabIndex = 4;
            this.tabPdfCombine.Text = "PDF Combine";
            // 
            // resetFiles
            // 
            this.resetFiles.Location = new System.Drawing.Point(392, 336);
            this.resetFiles.Margin = new System.Windows.Forms.Padding(4);
            this.resetFiles.Name = "resetFiles";
            this.resetFiles.Size = new System.Drawing.Size(177, 28);
            this.resetFiles.TabIndex = 46;
            this.resetFiles.Text = "Reset";
            this.resetFiles.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 286);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(604, 28);
            this.progressBar1.TabIndex = 45;
            // 
            // flowLayoutFiles
            // 
            this.flowLayoutFiles.AllowDrop = true;
            this.flowLayoutFiles.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutFiles.Location = new System.Drawing.Point(171, 63);
            this.flowLayoutFiles.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutFiles.Name = "flowLayoutFiles";
            this.flowLayoutFiles.Size = new System.Drawing.Size(603, 190);
            this.flowLayoutFiles.TabIndex = 44;
            // 
            // PdfCombineButton
            // 
            this.PdfCombineButton.Location = new System.Drawing.Point(392, 395);
            this.PdfCombineButton.Margin = new System.Windows.Forms.Padding(4);
            this.PdfCombineButton.Name = "PdfCombineButton";
            this.PdfCombineButton.Size = new System.Drawing.Size(177, 28);
            this.PdfCombineButton.TabIndex = 43;
            this.PdfCombineButton.Text = "Combine PDF";
            this.PdfCombineButton.UseVisualStyleBackColor = true;
            // 
            // tabImageToPdf
            // 
            this.tabImageToPdf.BackColor = System.Drawing.SystemColors.Control;
            this.tabImageToPdf.Controls.Add(this.resetFiles2);
            this.tabImageToPdf.Controls.Add(this.progressBar2);
            this.tabImageToPdf.Controls.Add(this.flowLayoutFiles2);
            this.tabImageToPdf.Controls.Add(this.ImageToPdfButton);
            this.tabImageToPdf.Location = new System.Drawing.Point(4, 25);
            this.tabImageToPdf.Margin = new System.Windows.Forms.Padding(4);
            this.tabImageToPdf.Name = "tabImageToPdf";
            this.tabImageToPdf.Padding = new System.Windows.Forms.Padding(4);
            this.tabImageToPdf.Size = new System.Drawing.Size(1019, 457);
            this.tabImageToPdf.TabIndex = 5;
            this.tabImageToPdf.Text = "ImageToPdf";
            // 
            // resetFiles2
            // 
            this.resetFiles2.Location = new System.Drawing.Point(428, 320);
            this.resetFiles2.Margin = new System.Windows.Forms.Padding(4);
            this.resetFiles2.Name = "resetFiles2";
            this.resetFiles2.Size = new System.Drawing.Size(177, 28);
            this.resetFiles2.TabIndex = 50;
            this.resetFiles2.Text = "Reset";
            this.resetFiles2.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(207, 270);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(604, 28);
            this.progressBar2.TabIndex = 49;
            // 
            // flowLayoutFiles2
            // 
            this.flowLayoutFiles2.AllowDrop = true;
            this.flowLayoutFiles2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutFiles2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutFiles2.Location = new System.Drawing.Point(207, 47);
            this.flowLayoutFiles2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutFiles2.Name = "flowLayoutFiles2";
            this.flowLayoutFiles2.Size = new System.Drawing.Size(603, 190);
            this.flowLayoutFiles2.TabIndex = 48;
            // 
            // ImageToPdfButton
            // 
            this.ImageToPdfButton.Location = new System.Drawing.Point(428, 379);
            this.ImageToPdfButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImageToPdfButton.Name = "ImageToPdfButton";
            this.ImageToPdfButton.Size = new System.Drawing.Size(177, 28);
            this.ImageToPdfButton.TabIndex = 47;
            this.ImageToPdfButton.Text = "Convert to PDF";
            this.ImageToPdfButton.UseVisualStyleBackColor = true;
            // 
            // tabWatermark
            // 
            this.tabWatermark.BackColor = System.Drawing.SystemColors.Control;
            this.tabWatermark.Controls.Add(this.progressBar3);
            this.tabWatermark.Controls.Add(this.label21);
            this.tabWatermark.Controls.Add(this.WatermarkButton);
            this.tabWatermark.Controls.Add(this.textBoxWatermark);
            this.tabWatermark.Controls.Add(this.sourceVideoButton5);
            this.tabWatermark.Controls.Add(this.textBoxSourceFile6);
            this.tabWatermark.Controls.Add(this.label20);
            this.tabWatermark.Location = new System.Drawing.Point(4, 25);
            this.tabWatermark.Name = "tabWatermark";
            this.tabWatermark.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatermark.Size = new System.Drawing.Size(1019, 457);
            this.tabWatermark.TabIndex = 7;
            this.tabWatermark.Text = "WatermarkPDF";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(216, 241);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(604, 28);
            this.progressBar3.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(143, 134);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "Write your watermark";
            // 
            // WatermarkButton
            // 
            this.WatermarkButton.Enabled = false;
            this.WatermarkButton.Location = new System.Drawing.Point(400, 351);
            this.WatermarkButton.Margin = new System.Windows.Forms.Padding(4);
            this.WatermarkButton.Name = "WatermarkButton";
            this.WatermarkButton.Size = new System.Drawing.Size(177, 28);
            this.WatermarkButton.TabIndex = 46;
            this.WatermarkButton.Text = "Write Watermark";
            this.WatermarkButton.UseVisualStyleBackColor = true;
            // 
            // textBoxWatermark
            // 
            this.textBoxWatermark.Location = new System.Drawing.Point(146, 154);
            this.textBoxWatermark.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWatermark.Name = "textBoxWatermark";
            this.textBoxWatermark.Size = new System.Drawing.Size(504, 22);
            this.textBoxWatermark.TabIndex = 45;
            // 
            // sourceVideoButton5
            // 
            this.sourceVideoButton5.Location = new System.Drawing.Point(658, 84);
            this.sourceVideoButton5.Margin = new System.Windows.Forms.Padding(4);
            this.sourceVideoButton5.Name = "sourceVideoButton5";
            this.sourceVideoButton5.Size = new System.Drawing.Size(100, 28);
            this.sourceVideoButton5.TabIndex = 36;
            this.sourceVideoButton5.Text = "Choose";
            this.sourceVideoButton5.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFile6
            // 
            this.textBoxSourceFile6.Location = new System.Drawing.Point(146, 90);
            this.textBoxSourceFile6.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFile6.Name = "textBoxSourceFile6";
            this.textBoxSourceFile6.Size = new System.Drawing.Size(504, 22);
            this.textBoxSourceFile6.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(142, 70);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 16);
            this.label20.TabIndex = 34;
            this.label20.Text = "Select your pdf";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabSettings.Controls.Add(this.languageCb);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1019, 457);
            this.tabSettings.TabIndex = 6;
            this.tabSettings.Text = "Settings";
            // 
            // languageCb
            // 
            this.languageCb.FormattingEnabled = true;
            this.languageCb.Location = new System.Drawing.Point(128, 36);
            this.languageCb.Name = "languageCb";
            this.languageCb.Size = new System.Drawing.Size(156, 24);
            this.languageCb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Language";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(17, 11);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(23, 25);
            this.aboutLabel.TabIndex = 19;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "?";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowAbout);
            // 
            // DopplerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 554);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.versionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DopplerView";
            this.Text = "Doppler";
            this.tabControl1.ResumeLayout(false);
            this.tabVideoToImage.ResumeLayout(false);
            this.tabVideoToImage.PerformLayout();
            this.tabTruncateVideo.ResumeLayout(false);
            this.tabTruncateVideo.PerformLayout();
            this.tabConvertMp.ResumeLayout(false);
            this.tabConvertMp.PerformLayout();
            this.tabMergeVideos.ResumeLayout(false);
            this.tabMergeVideos.PerformLayout();
            this.tabPdfCombine.ResumeLayout(false);
            this.tabImageToPdf.ResumeLayout(false);
            this.tabWatermark.ResumeLayout(false);
            this.tabWatermark.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label versionLabel;
        public System.Windows.Forms.OpenFileDialog fileDialog;
        public System.Windows.Forms.OpenFileDialog openFileDialogDestination;
        public System.Windows.Forms.OpenFileDialog openFileDialogFfmpeg;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabTruncateVideo;
        public System.Windows.Forms.TabPage tabConvertMp;
        public System.Windows.Forms.TabPage tabMergeVideos;
        public System.Windows.Forms.TabPage tabPdfCombine;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxSourceFile2;
        public System.Windows.Forms.TextBox textBoxDestinationFolder2;
        public System.Windows.Forms.TextBox textBoxFfmpegPath2;
        public System.Windows.Forms.Button sourceVideoButton2;
        public System.Windows.Forms.Button destinationFolderButton2;
        public System.Windows.Forms.Button ffmpegButton2;

        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button TruncateVideoButton;
  

        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox endTime;
        public System.Windows.Forms.TextBox startTime;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button MpConvertButton;
        public System.Windows.Forms.Button ffmpegButton3;
        public System.Windows.Forms.TextBox textBoxFfmpegPath3;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button destinationFolderButton3;
        public System.Windows.Forms.TextBox textBoxDestinationFolder3;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button sourceMusicButton;
        public System.Windows.Forms.TextBox textBoxSourceFile3;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button sourceVideoButton4;
        public System.Windows.Forms.TextBox textBoxSourceFile5;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Button MergeVideoButton;
        public System.Windows.Forms.Button ffmpegButton4;
        public System.Windows.Forms.TextBox textBoxFfmpegPath4;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button destinationFolderButton4;
        public System.Windows.Forms.TextBox textBoxDestinationFolder4;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button sourceVideoButton3;
        public System.Windows.Forms.TextBox textBoxSourceFile4;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button PdfCombineButton;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutFiles;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button resetFiles;
        private System.Windows.Forms.TabPage tabImageToPdf;
        public System.Windows.Forms.Button resetFiles2;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutFiles2;
        public System.Windows.Forms.Button ImageToPdfButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton mp4radioButton;
        private System.Windows.Forms.RadioButton mp3radioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TabPage tabVideoToImage;
        public System.Windows.Forms.TextBox textBoxSourceFile;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button sourceVideoButton;
        public System.Windows.Forms.TextBox textBoxFfmpegPath;
        public System.Windows.Forms.Button ffmpegButton;
        public System.Windows.Forms.Button ConvertImageButton;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBoxDestinationFolder;
        public System.Windows.Forms.Button destinationFolderButton;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ComboBox languageCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabWatermark;
        public System.Windows.Forms.Button WatermarkButton;
        public System.Windows.Forms.TextBox textBoxWatermark;
        public System.Windows.Forms.Button sourceVideoButton5;
        public System.Windows.Forms.TextBox textBoxSourceFile6;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.ProgressBar progressBar3;
    }
}