using Doppler.Components;

namespace Doppler
{
    partial class DopplerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DopplerForm));
            this.ConvertImageButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.textBoxFfmpegPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceVideoButton = new System.Windows.Forms.Button();
            this.destinationFolderButton = new System.Windows.Forms.Button();
            this.ffmpegButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDestination = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFfmpeg = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Mp3ConvertButton = new System.Windows.Forms.Button();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.themeSwitch = new Switch();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertImageButton
            // 
            this.ConvertImageButton.Location = new System.Drawing.Point(305, 316);
            this.ConvertImageButton.Name = "ConvertImageButton";
            this.ConvertImageButton.Size = new System.Drawing.Size(133, 23);
            this.ConvertImageButton.TabIndex = 0;
            this.ConvertImageButton.Text = "Convert into images";
            this.ConvertImageButton.UseVisualStyleBackColor = true;
            this.ConvertImageButton.Click += this.Converter.Launch;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(710, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(104, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version: {VERSION}";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(55, 60);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile.TabIndex = 2;
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(55, 134);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(380, 20);
            this.textBoxDestinationFolder.TabIndex = 3;
            // 
            // textBoxFfmpegPath
            // 
            this.textBoxFfmpegPath.Location = new System.Drawing.Point(56, 231);
            this.textBoxFfmpegPath.Name = "textBoxFfmpegPath";
            this.textBoxFfmpegPath.Size = new System.Drawing.Size(379, 20);
            this.textBoxFfmpegPath.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose a video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location of FFMPEG.exe";
            // 
            // sourceVideoButton
            // 
            this.sourceVideoButton.Location = new System.Drawing.Point(440, 57);
            this.sourceVideoButton.Name = "sourceVideoButton";
            this.sourceVideoButton.Size = new System.Drawing.Size(75, 23);
            this.sourceVideoButton.TabIndex = 6;
            this.sourceVideoButton.Text = "Choose";
            this.sourceVideoButton.UseVisualStyleBackColor = true;
            this.sourceVideoButton.Click += this.Converter.DefinePath;
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(440, 134);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton.TabIndex = 7;
            this.destinationFolderButton.Text = "Choose";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            this.destinationFolderButton.Click += this.Converter.DefinePath;
            // 
            // ffmpegButton
            // 
            this.ffmpegButton.Location = new System.Drawing.Point(441, 228);
            this.ffmpegButton.Name = "ffmpegButton";
            this.ffmpegButton.Size = new System.Drawing.Size(75, 23);
            this.ffmpegButton.TabIndex = 11;
            this.ffmpegButton.Text = "Choose";
            this.ffmpegButton.UseVisualStyleBackColor = true;
            this.ffmpegButton.Click += this.Converter.DefinePath;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doppler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select the folder to save images";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Location = new System.Drawing.Point(177, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Download";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tool to convert video into images";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(710, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github project";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToGithub);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 395);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.textBoxSourceFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.sourceVideoButton);
            this.tabPage1.Controls.Add(this.textBoxFfmpegPath);
            this.tabPage1.Controls.Add(this.ffmpegButton);
            this.tabPage1.Controls.Add(this.ConvertImageButton);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBoxDestinationFolder);
            this.tabPage1.Controls.Add(this.destinationFolderButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VideoToImages";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.endTime);
            this.tabPage2.Controls.Add(this.startTime);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TruncateVideoButton);
            this.tabPage2.Controls.Add(this.ffmpegButton2);
            this.tabPage2.Controls.Add(this.textBoxFfmpegPath2);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.destinationFolderButton2);
            this.tabPage2.Controls.Add(this.textBoxDestinationFolder2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.sourceVideoButton2);
            this.tabPage2.Controls.Add(this.textBoxSourceFile2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TruncateVideo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tool to truncate video with start and end time";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(324, 144);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(110, 20);
            this.endTime.TabIndex = 22;
            this.endTime.TextChanged += this.Truncater.DefineTime;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(109, 144);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(117, 20);
            this.startTime.TabIndex = 21;
            this.startTime.TextChanged += this.Truncater.DefineTime;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "End time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Start time";
            // 
            // TruncateVideoButton
            // 
            this.TruncateVideoButton.Location = new System.Drawing.Point(273, 310);
            this.TruncateVideoButton.Name = "TruncateVideoButton";
            this.TruncateVideoButton.Size = new System.Drawing.Size(133, 23);
            this.TruncateVideoButton.TabIndex = 18;
            this.TruncateVideoButton.Text = "Truncate the video";
            this.TruncateVideoButton.UseVisualStyleBackColor = true;
            this.TruncateVideoButton.Click += this.Truncater.Launch;
            // 
            // ffmpegButton2
            // 
            this.ffmpegButton2.Location = new System.Drawing.Point(441, 213);
            this.ffmpegButton2.Name = "ffmpegButton2";
            this.ffmpegButton2.Size = new System.Drawing.Size(75, 23);
            this.ffmpegButton2.TabIndex = 17;
            this.ffmpegButton2.Text = "Choose";
            this.ffmpegButton2.UseVisualStyleBackColor = true;
            this.ffmpegButton2.Click += this.Truncater.DefinePath;
            // 
            // textBoxFfmpegPath2
            // 
            this.textBoxFfmpegPath2.Location = new System.Drawing.Point(55, 213);
            this.textBoxFfmpegPath2.Name = "textBoxFfmpegPath2";
            this.textBoxFfmpegPath2.Size = new System.Drawing.Size(379, 20);
            this.textBoxFfmpegPath2.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(213, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Download";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Help;
            this.button8.Location = new System.Drawing.Point(184, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton2
            // 
            this.destinationFolderButton2.Location = new System.Drawing.Point(441, 107);
            this.destinationFolderButton2.Name = "destinationFolderButton2";
            this.destinationFolderButton2.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton2.TabIndex = 12;
            this.destinationFolderButton2.Text = "Choose";
            this.destinationFolderButton2.UseVisualStyleBackColor = true;
            this.destinationFolderButton2.Click += this.Truncater.DefinePath;
            // 
            // textBoxDestinationFolder2
            // 
            this.textBoxDestinationFolder2.Location = new System.Drawing.Point(54, 109);
            this.textBoxDestinationFolder2.Name = "textBoxDestinationFolder2";
            this.textBoxDestinationFolder2.Size = new System.Drawing.Size(380, 20);
            this.textBoxDestinationFolder2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select the folder to save new video";
            // 
            // sourceVideoButton2
            // 
            this.sourceVideoButton2.Location = new System.Drawing.Point(440, 61);
            this.sourceVideoButton2.Name = "sourceVideoButton2";
            this.sourceVideoButton2.Size = new System.Drawing.Size(75, 23);
            this.sourceVideoButton2.TabIndex = 7;
            this.sourceVideoButton2.Text = "Choose";
            this.sourceVideoButton2.UseVisualStyleBackColor = true;
            this.sourceVideoButton2.Click += this.Truncater.DefinePath;
            // 
            // textBoxSourceFile2
            // 
            this.textBoxSourceFile2.Location = new System.Drawing.Point(55, 61);
            this.textBoxSourceFile2.Name = "textBoxSourceFile2";
            this.textBoxSourceFile2.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose a video";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.Mp3ConvertButton);
            this.tabPage3.Controls.Add(this.ffmpegButton3);
            this.tabPage3.Controls.Add(this.textBoxFfmpegPath3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.destinationFolderButton3);
            this.tabPage3.Controls.Add(this.textBoxDestinationFolder3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.sourceMusicButton);
            this.tabPage3.Controls.Add(this.textBoxSourceFile3);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ConvertMp3";
            // 
            // Mp3ConvertButton
            // 
            this.Mp3ConvertButton.Location = new System.Drawing.Point(276, 310);
            this.Mp3ConvertButton.Name = "Mp3ConvertButton";
            this.Mp3ConvertButton.Size = new System.Drawing.Size(133, 23);
            this.Mp3ConvertButton.TabIndex = 30;
            this.Mp3ConvertButton.Text = "Convert to MP3";
            this.Mp3ConvertButton.UseVisualStyleBackColor = true;
            this.Mp3ConvertButton.Click += this.Mp3Converter.Launch;
            // 
            // ffmpegButton3
            // 
            this.ffmpegButton3.Location = new System.Drawing.Point(444, 213);
            this.ffmpegButton3.Name = "ffmpegButton3";
            this.ffmpegButton3.Size = new System.Drawing.Size(75, 23);
            this.ffmpegButton3.TabIndex = 29;
            this.ffmpegButton3.Text = "Choose";
            this.ffmpegButton3.UseVisualStyleBackColor = true;
            this.ffmpegButton3.Click += this.Mp3Converter.DefinePath;
            // 
            // textBoxFfmpegPath3
            // 
            this.textBoxFfmpegPath3.Location = new System.Drawing.Point(58, 213);
            this.textBoxFfmpegPath3.Name = "textBoxFfmpegPath3";
            this.textBoxFfmpegPath3.Size = new System.Drawing.Size(379, 20);
            this.textBoxFfmpegPath3.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Help;
            this.button6.Location = new System.Drawing.Point(187, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton3
            // 
            this.destinationFolderButton3.Location = new System.Drawing.Point(444, 107);
            this.destinationFolderButton3.Name = "destinationFolderButton3";
            this.destinationFolderButton3.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton3.TabIndex = 24;
            this.destinationFolderButton3.Text = "Choose";
            this.destinationFolderButton3.UseVisualStyleBackColor = true;
            this.destinationFolderButton3.Click += this.Mp3Converter.DefinePath;
            // 
            // textBoxDestinationFolder3
            // 
            this.textBoxDestinationFolder3.Location = new System.Drawing.Point(57, 109);
            this.textBoxDestinationFolder3.Name = "textBoxDestinationFolder3";
            this.textBoxDestinationFolder3.Size = new System.Drawing.Size(380, 20);
            this.textBoxDestinationFolder3.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Select the folder to save mp3 music";
            // 
            // sourceMusicButton
            // 
            this.sourceMusicButton.Location = new System.Drawing.Point(443, 61);
            this.sourceMusicButton.Name = "sourceMusicButton";
            this.sourceMusicButton.Size = new System.Drawing.Size(75, 23);
            this.sourceMusicButton.TabIndex = 21;
            this.sourceMusicButton.Text = "Choose";
            this.sourceMusicButton.UseVisualStyleBackColor = true;
            this.sourceMusicButton.Click += this.Mp3Converter.DefinePath;
            // 
            // textBoxSourceFile3
            // 
            this.textBoxSourceFile3.Location = new System.Drawing.Point(58, 61);
            this.textBoxSourceFile3.Name = "textBoxSourceFile3";
            this.textBoxSourceFile3.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile3.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Choose a music (mp4, ogg, m4a, etc...)";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.sourceVideoButton4);
            this.tabPage4.Controls.Add(this.textBoxSourceFile5);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.MergeVideoButton);
            this.tabPage4.Controls.Add(this.ffmpegButton4);
            this.tabPage4.Controls.Add(this.textBoxFfmpegPath4);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.destinationFolderButton4);
            this.tabPage4.Controls.Add(this.textBoxDestinationFolder4);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.sourceVideoButton3);
            this.tabPage4.Controls.Add(this.textBoxSourceFile4);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MergeVideos";
            // 
            // sourceVideoButton4
            // 
            this.sourceVideoButton4.Location = new System.Drawing.Point(457, 117);
            this.sourceVideoButton4.Name = "sourceVideoButton4";
            this.sourceVideoButton4.Size = new System.Drawing.Size(75, 23);
            this.sourceVideoButton4.TabIndex = 45;
            this.sourceVideoButton4.Text = "Choose";
            this.sourceVideoButton4.UseVisualStyleBackColor = true;
            this.sourceVideoButton4.Click += this.VideoMerger.DefinePath;
            // 
            // textBoxSourceFile5
            // 
            this.textBoxSourceFile5.Location = new System.Drawing.Point(72, 117);
            this.textBoxSourceFile5.Name = "textBoxSourceFile5";
            this.textBoxSourceFile5.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile5.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(69, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Choose second video";
            // 
            // MergeVideoButton
            // 
            this.MergeVideoButton.Location = new System.Drawing.Point(291, 322);
            this.MergeVideoButton.Name = "MergeVideoButton";
            this.MergeVideoButton.Size = new System.Drawing.Size(133, 23);
            this.MergeVideoButton.TabIndex = 42;
            this.MergeVideoButton.Text = "Merge videos";
            this.MergeVideoButton.UseVisualStyleBackColor = true;
            this.MergeVideoButton.Click += this.VideoMerger.Launch;
            // 
            // ffmpegButton4
            // 
            this.ffmpegButton4.Location = new System.Drawing.Point(459, 225);
            this.ffmpegButton4.Name = "ffmpegButton4";
            this.ffmpegButton4.Size = new System.Drawing.Size(75, 23);
            this.ffmpegButton4.TabIndex = 41;
            this.ffmpegButton4.Text = "Choose";
            this.ffmpegButton4.UseVisualStyleBackColor = true;
            this.ffmpegButton4.Click += this.VideoMerger.DefinePath;
            // 
            // textBoxFfmpegPath4
            // 
            this.textBoxFfmpegPath4.Location = new System.Drawing.Point(73, 225);
            this.textBoxFfmpegPath4.Name = "textBoxFfmpegPath4";
            this.textBoxFfmpegPath4.Size = new System.Drawing.Size(379, 20);
            this.textBoxFfmpegPath4.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(231, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 39;
            this.button7.Text = "Download";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.LinkToDownload);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Help;
            this.button10.Location = new System.Drawing.Point(202, 201);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "?";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Location of FFMPEG.exe";
            // 
            // destinationFolderButton4
            // 
            this.destinationFolderButton4.Location = new System.Drawing.Point(458, 173);
            this.destinationFolderButton4.Name = "destinationFolderButton4";
            this.destinationFolderButton4.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton4.TabIndex = 36;
            this.destinationFolderButton4.Text = "Choose";
            this.destinationFolderButton4.UseVisualStyleBackColor = true;
            this.destinationFolderButton4.Click += this.VideoMerger.DefinePath;
            // 
            // textBoxDestinationFolder4
            // 
            this.textBoxDestinationFolder4.Location = new System.Drawing.Point(72, 175);
            this.textBoxDestinationFolder4.Name = "textBoxDestinationFolder4";
            this.textBoxDestinationFolder4.Size = new System.Drawing.Size(380, 20);
            this.textBoxDestinationFolder4.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Select the folder to save mp3 music";
            // 
            // sourceVideoButton3
            // 
            this.sourceVideoButton3.Location = new System.Drawing.Point(458, 73);
            this.sourceVideoButton3.Name = "sourceVideoButton3";
            this.sourceVideoButton3.Size = new System.Drawing.Size(75, 23);
            this.sourceVideoButton3.TabIndex = 33;
            this.sourceVideoButton3.Text = "Choose";
            this.sourceVideoButton3.UseVisualStyleBackColor = true;
            this.sourceVideoButton3.Click += this.VideoMerger.DefinePath;
            // 
            // textBoxSourceFile4
            // 
            this.textBoxSourceFile4.Location = new System.Drawing.Point(73, 73);
            this.textBoxSourceFile4.Name = "textBoxSourceFile4";
            this.textBoxSourceFile4.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile4.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Choose first video";
            // 
            // themeSwitch
            // 
            this.themeSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.BackColor = System.Drawing.Color.White;
            this.themeSwitch.FlatAppearance.BorderSize = 0;
            this.themeSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeSwitch.Location = new System.Drawing.Point(16, 13);
            this.themeSwitch.MinimumSize = new System.Drawing.Size(30, 15);
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Size = new System.Drawing.Size(53, 23);
            this.themeSwitch.TabIndex = 17;
            this.themeSwitch.Text = "switch1";
            this.themeSwitch.UseVisualStyleBackColor = false;
            this.themeSwitch.Click += this.ThemeManager.ChangeTheme;
            // 
            // DopplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.themeSwitch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.versionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DopplerForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ConvertImageButton;
        public System.Windows.Forms.Label versionLabel;
        public System.Windows.Forms.TextBox textBoxSourceFile;
        public System.Windows.Forms.TextBox textBoxDestinationFolder;
        public System.Windows.Forms.TextBox textBoxFfmpegPath;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button sourceVideoButton;
        public System.Windows.Forms.Button destinationFolderButton;
        public System.Windows.Forms.Button ffmpegButton;
        public System.Windows.Forms.OpenFileDialog fileDialog;
        public System.Windows.Forms.OpenFileDialog openFileDialogDestination;
        public System.Windows.Forms.OpenFileDialog openFileDialogFfmpeg;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
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
        public Switch themeSwitch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Button Mp3ConvertButton;
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
    }
}

