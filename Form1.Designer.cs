
namespace YTDL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mehet = new System.Windows.Forms.Button();
            this.audio = new System.Windows.Forms.RadioButton();
            this.video = new System.Windows.Forms.RadioButton();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.Button();
            this.updateText = new System.Windows.Forms.Label();
            this.notifier = new System.Windows.Forms.Label();
            this.ffmpegBtn = new System.Windows.Forms.Button();
            this.ffmpegText = new System.Windows.Forms.Label();
            this.ffmpegDownloading = new System.Windows.Forms.Label();
            this.ytdlDownload = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.url2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.audio2 = new System.Windows.Forms.RadioButton();
            this.video2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.audio3 = new System.Windows.Forms.RadioButton();
            this.video3 = new System.Windows.Forms.RadioButton();
            this.url3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.audio4 = new System.Windows.Forms.RadioButton();
            this.video4 = new System.Windows.Forms.RadioButton();
            this.url4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.audio6 = new System.Windows.Forms.RadioButton();
            this.video6 = new System.Windows.Forms.RadioButton();
            this.url6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.audio7 = new System.Windows.Forms.RadioButton();
            this.video7 = new System.Windows.Forms.RadioButton();
            this.url7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.audio5 = new System.Windows.Forms.RadioButton();
            this.video5 = new System.Windows.Forms.RadioButton();
            this.url5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mehet
            // 
            this.mehet.Location = new System.Drawing.Point(153, 201);
            this.mehet.Name = "mehet";
            this.mehet.Size = new System.Drawing.Size(236, 34);
            this.mehet.TabIndex = 0;
            this.mehet.Text = "Download";
            this.mehet.UseVisualStyleBackColor = true;
            this.mehet.Click += new System.EventHandler(this.button1_Click);
            // 
            // audio
            // 
            this.audio.AutoSize = true;
            this.audio.Checked = true;
            this.audio.Location = new System.Drawing.Point(153, 171);
            this.audio.Name = "audio";
            this.audio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.audio.Size = new System.Drawing.Size(61, 19);
            this.audio.TabIndex = 2;
            this.audio.TabStop = true;
            this.audio.Text = "AUDIO";
            this.audio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.audio.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.AutoSize = true;
            this.video.Location = new System.Drawing.Point(331, 171);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(58, 19);
            this.video.TabIndex = 2;
            this.video.Text = "VIDEO";
            this.video.UseVisualStyleBackColor = true;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(153, 131);
            this.urlBox.Name = "urlBox";
            this.urlBox.PlaceholderText = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            this.urlBox.Size = new System.Drawing.Size(236, 23);
            this.urlBox.TabIndex = 4;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Cursor = System.Windows.Forms.Cursors.No;
            this.error.Location = new System.Drawing.Point(262, 109);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(13, 15);
            this.error.TabIndex = 6;
            this.error.Text = "0";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error.Visible = false;
            this.error.Click += new System.EventHandler(this.error_Click);
            // 
            // checkUpdate
            // 
            this.checkUpdate.Location = new System.Drawing.Point(379, 12);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(136, 23);
            this.checkUpdate.TabIndex = 8;
            this.checkUpdate.Text = "Update YTDL";
            this.checkUpdate.UseVisualStyleBackColor = true;
            this.checkUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // updateText
            // 
            this.updateText.AutoSize = true;
            this.updateText.Location = new System.Drawing.Point(410, 51);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(10, 15);
            this.updateText.TabIndex = 9;
            this.updateText.Text = " ";
            this.updateText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.updateText.Click += new System.EventHandler(this.label2_Click);
            // 
            // notifier
            // 
            this.notifier.AutoSize = true;
            this.notifier.Location = new System.Drawing.Point(91, 16);
            this.notifier.Name = "notifier";
            this.notifier.Size = new System.Drawing.Size(282, 15);
            this.notifier.TabIndex = 10;
            this.notifier.Text = "YTDL isn\'t downloaded, check here to download -->";
            this.notifier.Visible = false;
            this.notifier.Click += new System.EventHandler(this.notifier_Click);
            // 
            // ffmpegBtn
            // 
            this.ffmpegBtn.Location = new System.Drawing.Point(379, 42);
            this.ffmpegBtn.Name = "ffmpegBtn";
            this.ffmpegBtn.Size = new System.Drawing.Size(135, 23);
            this.ffmpegBtn.TabIndex = 11;
            this.ffmpegBtn.Text = "Update FFmpeg";
            this.ffmpegBtn.UseVisualStyleBackColor = true;
            this.ffmpegBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ffmpegText
            // 
            this.ffmpegText.AutoSize = true;
            this.ffmpegText.Location = new System.Drawing.Point(82, 46);
            this.ffmpegText.Name = "ffmpegText";
            this.ffmpegText.Size = new System.Drawing.Size(291, 15);
            this.ffmpegText.TabIndex = 12;
            this.ffmpegText.Text = "FFmpeg isn\'t downloaded, click here to download -->";
            this.ffmpegText.Visible = false;
            // 
            // ffmpegDownloading
            // 
            this.ffmpegDownloading.AutoSize = true;
            this.ffmpegDownloading.Location = new System.Drawing.Point(383, 68);
            this.ffmpegDownloading.Name = "ffmpegDownloading";
            this.ffmpegDownloading.Size = new System.Drawing.Size(130, 15);
            this.ffmpegDownloading.TabIndex = 13;
            this.ffmpegDownloading.Text = "Downloading FFmpeg..";
            this.ffmpegDownloading.Visible = false;
            // 
            // ytdlDownload
            // 
            this.ytdlDownload.AutoSize = true;
            this.ytdlDownload.Location = new System.Drawing.Point(390, 68);
            this.ytdlDownload.Name = "ytdlDownload";
            this.ytdlDownload.Size = new System.Drawing.Size(114, 15);
            this.ytdlDownload.TabIndex = 14;
            this.ytdlDownload.Text = "Downloading YTDL..\r\n";
            this.ytdlDownload.Visible = false;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(12, 12);
            this.count.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(70, 23);
            this.count.TabIndex = 15;
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // url2
            // 
            this.url2.Location = new System.Drawing.Point(4, 33);
            this.url2.Name = "url2";
            this.url2.PlaceholderText = "URL #2";
            this.url2.Size = new System.Drawing.Size(148, 23);
            this.url2.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.audio2);
            this.groupBox6.Controls.Add(this.video2);
            this.groupBox6.Controls.Add(this.url2);
            this.groupBox6.Location = new System.Drawing.Point(184, 241);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 60);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // audio2
            // 
            this.audio2.AutoSize = true;
            this.audio2.Checked = true;
            this.audio2.Location = new System.Drawing.Point(63, 14);
            this.audio2.Name = "audio2";
            this.audio2.Size = new System.Drawing.Size(14, 13);
            this.audio2.TabIndex = 24;
            this.audio2.TabStop = true;
            this.audio2.UseVisualStyleBackColor = true;
            // 
            // video2
            // 
            this.video2.AutoSize = true;
            this.video2.Location = new System.Drawing.Point(83, 14);
            this.video2.Name = "video2";
            this.video2.Size = new System.Drawing.Size(14, 13);
            this.video2.TabIndex = 23;
            this.video2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.audio3);
            this.groupBox7.Controls.Add(this.video3);
            this.groupBox7.Controls.Add(this.url3);
            this.groupBox7.Location = new System.Drawing.Point(12, 241);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(157, 60);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Visible = false;
            // 
            // audio3
            // 
            this.audio3.AutoSize = true;
            this.audio3.Checked = true;
            this.audio3.Location = new System.Drawing.Point(63, 14);
            this.audio3.Name = "audio3";
            this.audio3.Size = new System.Drawing.Size(14, 13);
            this.audio3.TabIndex = 24;
            this.audio3.TabStop = true;
            this.audio3.UseVisualStyleBackColor = true;
            // 
            // video3
            // 
            this.video3.AutoSize = true;
            this.video3.Location = new System.Drawing.Point(83, 14);
            this.video3.Name = "video3";
            this.video3.Size = new System.Drawing.Size(14, 13);
            this.video3.TabIndex = 23;
            this.video3.UseVisualStyleBackColor = true;
            // 
            // url3
            // 
            this.url3.Location = new System.Drawing.Point(4, 33);
            this.url3.Name = "url3";
            this.url3.PlaceholderText = "URL #3";
            this.url3.Size = new System.Drawing.Size(148, 23);
            this.url3.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.audio4);
            this.groupBox4.Controls.Add(this.video4);
            this.groupBox4.Controls.Add(this.url4);
            this.groupBox4.Location = new System.Drawing.Point(352, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 60);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // audio4
            // 
            this.audio4.AutoSize = true;
            this.audio4.Checked = true;
            this.audio4.Location = new System.Drawing.Point(63, 14);
            this.audio4.Name = "audio4";
            this.audio4.Size = new System.Drawing.Size(14, 13);
            this.audio4.TabIndex = 24;
            this.audio4.TabStop = true;
            this.audio4.UseVisualStyleBackColor = true;
            // 
            // video4
            // 
            this.video4.AutoSize = true;
            this.video4.Location = new System.Drawing.Point(83, 14);
            this.video4.Name = "video4";
            this.video4.Size = new System.Drawing.Size(14, 13);
            this.video4.TabIndex = 23;
            this.video4.UseVisualStyleBackColor = true;
            // 
            // url4
            // 
            this.url4.Location = new System.Drawing.Point(4, 33);
            this.url4.Name = "url4";
            this.url4.PlaceholderText = "URL #4";
            this.url4.Size = new System.Drawing.Size(148, 23);
            this.url4.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.audio6);
            this.groupBox3.Controls.Add(this.video6);
            this.groupBox3.Controls.Add(this.url6);
            this.groupBox3.Location = new System.Drawing.Point(184, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 60);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // audio6
            // 
            this.audio6.AutoSize = true;
            this.audio6.Checked = true;
            this.audio6.Location = new System.Drawing.Point(63, 14);
            this.audio6.Name = "audio6";
            this.audio6.Size = new System.Drawing.Size(14, 13);
            this.audio6.TabIndex = 24;
            this.audio6.TabStop = true;
            this.audio6.UseVisualStyleBackColor = true;
            // 
            // video6
            // 
            this.video6.AutoSize = true;
            this.video6.Location = new System.Drawing.Point(83, 14);
            this.video6.Name = "video6";
            this.video6.Size = new System.Drawing.Size(14, 13);
            this.video6.TabIndex = 23;
            this.video6.UseVisualStyleBackColor = true;
            // 
            // url6
            // 
            this.url6.Location = new System.Drawing.Point(4, 33);
            this.url6.Name = "url6";
            this.url6.PlaceholderText = "URL #6";
            this.url6.Size = new System.Drawing.Size(148, 23);
            this.url6.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.audio7);
            this.groupBox2.Controls.Add(this.video7);
            this.groupBox2.Controls.Add(this.url7);
            this.groupBox2.Location = new System.Drawing.Point(352, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 60);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // audio7
            // 
            this.audio7.AutoSize = true;
            this.audio7.Checked = true;
            this.audio7.Location = new System.Drawing.Point(63, 14);
            this.audio7.Name = "audio7";
            this.audio7.Size = new System.Drawing.Size(14, 13);
            this.audio7.TabIndex = 24;
            this.audio7.TabStop = true;
            this.audio7.UseVisualStyleBackColor = true;
            // 
            // video7
            // 
            this.video7.AutoSize = true;
            this.video7.Location = new System.Drawing.Point(83, 14);
            this.video7.Name = "video7";
            this.video7.Size = new System.Drawing.Size(14, 13);
            this.video7.TabIndex = 23;
            this.video7.UseVisualStyleBackColor = true;
            // 
            // url7
            // 
            this.url7.Location = new System.Drawing.Point(4, 33);
            this.url7.Name = "url7";
            this.url7.PlaceholderText = "URL #7";
            this.url7.Size = new System.Drawing.Size(148, 23);
            this.url7.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.audio5);
            this.groupBox1.Controls.Add(this.video5);
            this.groupBox1.Controls.Add(this.url5);
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 60);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // audio5
            // 
            this.audio5.AutoSize = true;
            this.audio5.Checked = true;
            this.audio5.Location = new System.Drawing.Point(63, 14);
            this.audio5.Name = "audio5";
            this.audio5.Size = new System.Drawing.Size(14, 13);
            this.audio5.TabIndex = 24;
            this.audio5.TabStop = true;
            this.audio5.UseVisualStyleBackColor = true;
            // 
            // video5
            // 
            this.video5.AutoSize = true;
            this.video5.Location = new System.Drawing.Point(83, 14);
            this.video5.Name = "video5";
            this.video5.Size = new System.Drawing.Size(14, 13);
            this.video5.TabIndex = 23;
            this.video5.UseVisualStyleBackColor = true;
            // 
            // url5
            // 
            this.url5.Location = new System.Drawing.Point(4, 33);
            this.url5.Name = "url5";
            this.url5.PlaceholderText = "URL #5";
            this.url5.Size = new System.Drawing.Size(148, 23);
            this.url5.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.count);
            this.Controls.Add(this.ytdlDownload);
            this.Controls.Add(this.ffmpegDownloading);
            this.Controls.Add(this.ffmpegText);
            this.Controls.Add(this.ffmpegBtn);
            this.Controls.Add(this.notifier);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.checkUpdate);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.video);
            this.Controls.Add(this.audio);
            this.Controls.Add(this.mehet);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 417);
            this.MinimumSize = new System.Drawing.Size(543, 417);
            this.Name = "Form1";
            this.Text = "YTDL Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mehet;
        private System.Windows.Forms.RadioButton audio;
        private System.Windows.Forms.RadioButton video;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button checkUpdate;
        private System.Windows.Forms.Label updateText;
        private System.Windows.Forms.Label notifier;
        private System.Windows.Forms.Button ffmpegBtn;
        private System.Windows.Forms.Label ffmpegText;
        private System.Windows.Forms.Label ffmpegDownloading;
        private System.Windows.Forms.Label ytdlDownload;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton audio2;
        private System.Windows.Forms.RadioButton video2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton audio3;
        private System.Windows.Forms.RadioButton video3;
        private System.Windows.Forms.TextBox url3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton audio4;
        private System.Windows.Forms.RadioButton video4;
        private System.Windows.Forms.TextBox url4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton audio6;
        private System.Windows.Forms.RadioButton video6;
        private System.Windows.Forms.TextBox url6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton audio7;
        private System.Windows.Forms.RadioButton video7;
        private System.Windows.Forms.TextBox url7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton audio5;
        private System.Windows.Forms.RadioButton video5;
        private System.Windows.Forms.TextBox url5;
    }
}

