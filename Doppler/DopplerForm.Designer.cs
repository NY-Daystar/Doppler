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
            this.LaunchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.textBoxFfmpegPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialogSource = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDestination = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFfmpeg = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(321, 365);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(133, 23);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch Doppler";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.Launch);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version: v1.0.0";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(93, 89);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(379, 20);
            this.textBoxSourceFile.TabIndex = 2;
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(93, 147);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(380, 20);
            this.textBoxDestinationFolder.TabIndex = 3;
            // 
            // textBoxFfmpegPath
            // 
            this.textBoxFfmpegPath.Location = new System.Drawing.Point(93, 312);
            this.textBoxFfmpegPath.Name = "textBoxFfmpegPath";
            this.textBoxFfmpegPath.Size = new System.Drawing.Size(379, 20);
            this.textBoxFfmpegPath.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose a video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location of FFMPEG.exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "choisir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetVideoToConvert);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "choisir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetFFMPEGfile);
            // 
            // openFileDialogSource
            // 
            this.openFileDialogSource.FileName = "openFileDialog1";
            // 
            // openFileDialogDestination
            // 
            this.openFileDialogDestination.FileName = "openFileDialog1";
            // 
            // openFileDialogFfmpeg
            // 
            this.openFileDialogFfmpeg.FileName = "openFileDialog1";
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
            this.label5.Location = new System.Drawing.Point(90, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select the folder to save images";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "choisir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowDestingationFolder);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RedirectToDownload);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 286);
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
            this.label6.Location = new System.Drawing.Point(275, 52);
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
            // DopplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxFfmpegPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestinationFolder);
            this.Controls.Add(this.textBoxSourceFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaunchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DopplerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.TextBox textBoxFfmpegPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialogSource;
        private System.Windows.Forms.OpenFileDialog openFileDialogDestination;
        private System.Windows.Forms.OpenFileDialog openFileDialogFfmpeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

