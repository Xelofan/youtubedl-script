using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace YTDL
{
    public partial class Form1 : Form
    {
        public bool checkFile()
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkFFmpeg()
        {
            if (!File.Exists("ffmpeg.exe"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkBoth()
        {
            if(!checkFFmpeg() || !checkFile())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            if (!checkFile())
            {
                notifier.Visible = true;
                mehet.Enabled = false;
            }
            if (!checkFFmpeg())
            {
                ffmpegText.Visible = true;
            }
            if(!checkFFmpeg() || !checkFile())
            {
                mehet.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkUpdate.Enabled = false;
            ffmpegBtn.Enabled = false;
            mehet.Enabled = false;
            ytdlDownload.Visible = true;
            if (checkFile())
            {
                ProcessStartInfo update = new ProcessStartInfo();
                update.FileName = "youtube-dl.exe";
                update.Arguments = "-U";
                Process.Start(update);
            }
            else
            {
                WebClient webclient = new WebClient();
                webclient.DownloadFile("https://youtube-dl.org/downloads/latest/youtube-dl.exe", @"youtube-dl.exe");
                while (!File.Exists("youtube-dl.exe"))
                {

                }
                notifier.Visible = false;
            }
            checkUpdate.Enabled = true;
            ffmpegBtn.Enabled = true;
            ytdlDownload.Visible = false;
            if (checkBoth())
            {
            mehet.Enabled = true;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            checkUpdate.Enabled = false;
            ffmpegBtn.Enabled = false;
            ffmpegDownloading.Visible = true;
            if (!checkFFmpeg())
            {
                WebClient webclient = new WebClient();
                webclient.DownloadFile("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip", @"ffmpeg-essentials.zip");
                System.IO.Compression.ZipFile.ExtractToDirectory("ffmpeg-essentials.zip", "ffmpeg-essentials");
                File.Delete("ffmpeg-essentials.zip");
                //File.Move(@"ffmpeg-essentials/ffmpeg-?/bin/ffmpeg.exe", "ffmpeg.exe");
                string[] files = Directory.GetDirectories("ffmpeg-essentials");
                File.Move(files[0]+"/bin/ffmpeg.exe", "ffmpeg.exe");
                Directory.Delete("ffmpeg-essentials", true);
            }
            else
            {
                File.Delete("ffmpeg.exe");
                WebClient webclient = new WebClient();
                webclient.DownloadFile("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip", @"ffmpeg-essentials.zip");
                System.IO.Compression.ZipFile.ExtractToDirectory("ffmpeg-essentials.zip", "ffmpeg-essentials");
                File.Delete("ffmpeg-essentials.zip");
                //File.Move(@"ffmpeg-essentials/ffmpeg-?/bin/ffmpeg.exe", "ffmpeg.exe");
                string[] files = Directory.GetDirectories("ffmpeg-essentials");
                File.Move(files[0] + "/bin/ffmpeg.exe", "ffmpeg.exe");
                Directory.Delete("ffmpeg-essentials", true);

            }
            checkUpdate.Enabled = true;
            ffmpegBtn.Enabled = true;
            ffmpegDownloading.Visible = false;
            if (checkFFmpeg())
            {
                ffmpegText.Visible = false;
            }
            if (checkBoth())
            {
                mehet.Enabled = true;
            }
        }

        public void audioDownload(string url)
        {
            ProcessStartInfo audioDL = new ProcessStartInfo();
            audioDL.FileName = "youtube-dl.exe";
            audioDL.Arguments = @"--no-cache-dir --console-title " + url + " -x --audio-format \"mp3\" -o \"AUDIO/%(title)s.%(ext)s\" -i -f bestaudio";
            Process.Start(audioDL);
        }
        public void videoDownload(string url)
        {
            ProcessStartInfo videoDL = new ProcessStartInfo();
            videoDL.FileName = "youtube-dl.exe";
            videoDL.Arguments = @"--console-title " + url + " -f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4\" -o \"VIDEO/%(title)s.%(ext)s\" -i";
            Process.Start(videoDL);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            error.Text = "";
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "youtube-dl.exe";
//            ps.WindowStyle = ProcessWindowStyle.Normal;

            if (audio.Checked && !video.Checked)
            {
                ps.Arguments = @"--no-cache-dir --console-title "+urlBox.Text+" -x --audio-format \"mp3\" -o \"AUDIO/%(title)s.%(ext)s\" -i -f bestaudio";
            }else if(video.Checked && !audio.Checked)
            {
                ps.Arguments = @"--console-title " + urlBox.Text + " -f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4\" -o \"VIDEO/%(title)s.%(ext)s\" -i";
            }
            else
            {
                error.Text = "Ismeretlen hiba történt.";
            }

            if(urlBox.Text.Length <= 1)
            {
                error.Text = "Írj be valamilyen URL-t.";
            }
            
            Process.Start(ps);

            if(count.Value > 1)
            {
                if(audio2.Checked && !video2.Checked)
                {
                    audioDownload(url2.Text);
                }
                else
                {
                    videoDownload(url2.Text);
                }
            }
            if (count.Value > 2)
            {
                if (audio3.Checked && !video3.Checked)
                {
                    audioDownload(url3.Text);
                }
                else
                {
                    videoDownload(url3.Text);
                }
            }
            if (count.Value > 3)
            {
                if (audio4.Checked && !video4.Checked)
                {
                    audioDownload(url4.Text);
                }
                else
                {
                    videoDownload(url4.Text);
                }
            }
            if (count.Value > 4)
            {
                if (audio5.Checked && !video5.Checked)
                {
                    audioDownload(url5.Text);
                }
                else
                {
                    videoDownload(url5.Text);
                }
            }
            if (count.Value > 5)
            {
                if (audio6.Checked && !video6.Checked)
                {
                    audioDownload(url6.Text);
                }
                else
                {
                    videoDownload(url6.Text);
                }
            }
            if (count.Value > 6)
            {
                if (audio7.Checked && !video7.Checked)
                {
                    audioDownload(url7.Text);
                }
                else
                {
                    videoDownload(url7.Text);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            //updateText.Text = urlBox.Text;
            this.AcceptButton = mehet;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void notifier_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (count.Value > 1)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
            if (count.Value > 2)
            {
                groupBox7.Visible = true;
            }
            else
            {
                groupBox7.Visible = false;
            }
            if (count.Value > 3)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
            if (count.Value > 4)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            if (count.Value > 5)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
            if (count.Value > 6)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
