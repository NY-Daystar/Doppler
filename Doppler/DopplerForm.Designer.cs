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
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.sourceVideoButton.Text = "choisir";
            this.sourceVideoButton.UseVisualStyleBackColor = true;
            this.sourceVideoButton.Click += this.Converter.DefinePath;
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(440, 134);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton.TabIndex = 7;
            this.destinationFolderButton.Text = "choisir";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            this.destinationFolderButton.Click += this.Converter.DefinePath;
            // 
            // ffmpegButton
            // 
            this.ffmpegButton.Location = new System.Drawing.Point(441, 228);
            this.ffmpegButton.Name = "ffmpegButton";
            this.ffmpegButton.Size = new System.Drawing.Size(75, 23);
            this.ffmpegButton.TabIndex = 11;
            this.ffmpegButton.Text = "choisir";
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
            this.ffmpegButton2.Text = "choisir";
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
            this.destinationFolderButton2.Text = "choisir";
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
            this.sourceVideoButton2.Text = "choisir";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tool to truncate video with start and end time";
            // 
            // DopplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
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
    }
}

