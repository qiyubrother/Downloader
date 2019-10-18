using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    public partial class FrmDownloader : Form
    {
        public FrmDownloader()
        {
            InitializeComponent();
        }

        public string RemoteUrl { get; set; }
        public string LocalFileName { get; set; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblRemote.Text = RemoteUrl;
            lblLocal.Text = LocalFileName;
            Download(lblRemote.Text, lblLocal.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 下载服务器文件至客户端
        /// </summary>
        /// <param name="uri">被下载的文件地址</param>
        /// <param name="savePath">另存放的目录</param>
        public bool Download(string uri, string savePath)
        {
            string fileName;  //被下载的文件名
            if (uri.IndexOf("\\") > -1)
            {
                fileName = uri.Substring(uri.LastIndexOf("\\") + 1);
            }
            else
            {
                fileName = uri.Substring(uri.LastIndexOf("/") + 1);
            }

            WebClient client = new WebClient();
            try
            {
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(uri), savePath);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            //progressBar1.Value = (int)((e.ProgressPercentage / e.TotalBytesToReceive) * 100);
            //progressBar1.Invalidate();
            lblProgressPercentage.Text = e.ProgressPercentage.ToString() + "%";
            Text = $"Downloading...({e.BytesReceived / 1024}KB / {e.TotalBytesToReceive/1024}KB)";
        }

        private void btnCopyRemote_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblRemote.Text);
        }

        private void btnCopyLocal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblLocal.Text);
        }
    }

}
