using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Downloader;

namespace DownloaderDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDownloader downloader = new FrmDownloader();
            downloader.RemoteUrl = textBox1.Text;
            downloader.LocalFileName = textBox2.Text;
            if (downloader.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("下载成功。");
            }
            else
            {
                MessageBox.Show("下载失败！");
            }
        }
    }
}
