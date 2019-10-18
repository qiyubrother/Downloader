namespace Downloader
{
    partial class FrmDownloader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblRemote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopyRemote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCopyLocal = new System.Windows.Forms.Button();
            this.lblProgressPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(84, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(254, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLocal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocal.Location = new System.Drawing.Point(140, 64);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(460, 23);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemote
            // 
            this.lblRemote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemote.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemote.Location = new System.Drawing.Point(140, 38);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(460, 23);
            this.lblRemote.TabIndex = 1;
            this.lblRemote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(84, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(84, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Local";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopyRemote
            // 
            this.btnCopyRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyRemote.FlatAppearance.BorderSize = 0;
            this.btnCopyRemote.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCopyRemote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCopyRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyRemote.Image = global::Downloader.Properties.Resources.copy;
            this.btnCopyRemote.Location = new System.Drawing.Point(601, 38);
            this.btnCopyRemote.Name = "btnCopyRemote";
            this.btnCopyRemote.Size = new System.Drawing.Size(24, 23);
            this.btnCopyRemote.TabIndex = 7;
            this.btnCopyRemote.UseVisualStyleBackColor = true;
            this.btnCopyRemote.Click += new System.EventHandler(this.btnCopyRemote_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Downloader.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 62);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCopyLocal
            // 
            this.btnCopyLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyLocal.FlatAppearance.BorderSize = 0;
            this.btnCopyLocal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCopyLocal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCopyLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyLocal.Image = global::Downloader.Properties.Resources.copy;
            this.btnCopyLocal.Location = new System.Drawing.Point(601, 64);
            this.btnCopyLocal.Name = "btnCopyLocal";
            this.btnCopyLocal.Size = new System.Drawing.Size(24, 23);
            this.btnCopyLocal.TabIndex = 8;
            this.btnCopyLocal.UseVisualStyleBackColor = true;
            this.btnCopyLocal.Click += new System.EventHandler(this.btnCopyLocal_Click);
            // 
            // lblProgressPercentage
            // 
            this.lblProgressPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProgressPercentage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProgressPercentage.Location = new System.Drawing.Point(601, 12);
            this.lblProgressPercentage.Name = "lblProgressPercentage";
            this.lblProgressPercentage.Size = new System.Drawing.Size(31, 23);
            this.lblProgressPercentage.TabIndex = 9;
            this.lblProgressPercentage.Text = "100%";
            this.lblProgressPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 135);
            this.ControlBox = false;
            this.Controls.Add(this.lblProgressPercentage);
            this.Controls.Add(this.btnCopyLocal);
            this.Controls.Add(this.btnCopyRemote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRemote);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyRemote;
        private System.Windows.Forms.Button btnCopyLocal;
        private System.Windows.Forms.Label lblProgressPercentage;
    }
}

