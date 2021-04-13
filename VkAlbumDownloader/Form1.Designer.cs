
namespace VkAlbumDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblCountPhotos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.lblTockenState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterToken = new System.Windows.Forms.Button();
            this.btnURLEnter = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 338);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(384, 23);
            this.progressBar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "URL:";
            // 
            // tbSource
            // 
            this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSource.Enabled = false;
            this.tbSource.Location = new System.Drawing.Point(12, 101);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(292, 23);
            this.tbSource.TabIndex = 32;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(93, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "- выбрать папку и загрузить";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlbumName.Location = new System.Drawing.Point(131, 136);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(241, 15);
            this.lblAlbumName.TabIndex = 28;
            this.lblAlbumName.Text = "---";
            // 
            // lblCountPhotos
            // 
            this.lblCountPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountPhotos.Location = new System.Drawing.Point(131, 158);
            this.lblCountPhotos.Name = "lblCountPhotos";
            this.lblCountPhotos.Size = new System.Drawing.Size(241, 15);
            this.lblCountPhotos.TabIndex = 26;
            this.lblCountPhotos.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Количество фото:";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Location = new System.Drawing.Point(12, 294);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 24;
            this.DownloadButton.Text = "Загрузить";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // lblTockenState
            // 
            this.lblTockenState.AutoSize = true;
            this.lblTockenState.ForeColor = System.Drawing.Color.Red;
            this.lblTockenState.Location = new System.Drawing.Point(59, 22);
            this.lblTockenState.Name = "lblTockenState";
            this.lblTockenState.Size = new System.Drawing.Size(66, 15);
            this.lblTockenState.TabIndex = 23;
            this.lblTockenState.Text = "не активен";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название альбома:";
            // 
            // tbToken
            // 
            this.tbToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToken.Location = new System.Drawing.Point(12, 40);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(292, 23);
            this.tbToken.TabIndex = 21;
            this.tbToken.TextChanged += new System.EventHandler(this.tbToken_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Токен:";
            // 
            // btnEnterToken
            // 
            this.btnEnterToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterToken.Location = new System.Drawing.Point(310, 40);
            this.btnEnterToken.Name = "btnEnterToken";
            this.btnEnterToken.Size = new System.Drawing.Size(62, 23);
            this.btnEnterToken.TabIndex = 35;
            this.btnEnterToken.Text = "Ввод";
            this.btnEnterToken.UseVisualStyleBackColor = true;
            this.btnEnterToken.Click += new System.EventHandler(this.btnEnterToken_Click);
            // 
            // btnURLEnter
            // 
            this.btnURLEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnURLEnter.Location = new System.Drawing.Point(310, 101);
            this.btnURLEnter.Name = "btnURLEnter";
            this.btnURLEnter.Size = new System.Drawing.Size(62, 23);
            this.btnURLEnter.TabIndex = 36;
            this.btnURLEnter.Text = "Ввод";
            this.btnURLEnter.UseVisualStyleBackColor = true;
            this.btnURLEnter.Click += new System.EventHandler(this.btnURLEnter_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Location = new System.Drawing.Point(297, 294);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 37;
            this.btnInfo.Text = "Инфо";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnURLEnter);
            this.Controls.Add(this.btnEnterToken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.lblCountPhotos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.lblTockenState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "VkAlbumDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblCountPhotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label lblTockenState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterToken;
        private System.Windows.Forms.Button btnURLEnter;
        private System.Windows.Forms.Button btnInfo;
    }
}

