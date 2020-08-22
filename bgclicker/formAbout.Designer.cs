namespace bgclicker
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkHomepage = new System.Windows.Forms.LinkLabel();
            this.pictureboxFLY = new System.Windows.Forms.PictureBox();
            this.pictureboxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "FLY BGClicker\r\nVer 1.1.5.20082201\r\nProgrammed by Edward Wang\r\nLicensed under GNU " +
    "General Public License v3.0\r\nFLY Studio ©2011-2020 All Rights Reserved.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 97);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(161, 102);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(41, 12);
            this.linkGithub.TabIndex = 6;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "GitHub";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // linkHomepage
            // 
            this.linkHomepage.AutoSize = true;
            this.linkHomepage.Location = new System.Drawing.Point(85, 102);
            this.linkHomepage.Name = "linkHomepage";
            this.linkHomepage.Size = new System.Drawing.Size(53, 12);
            this.linkHomepage.TabIndex = 6;
            this.linkHomepage.TabStop = true;
            this.linkHomepage.Text = "Homepage";
            this.linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHomepage_LinkClicked);
            // 
            // pictureboxFLY
            // 
            this.pictureboxFLY.Image = global::bgclicker.Properties.Resources.flylogo;
            this.pictureboxFLY.Location = new System.Drawing.Point(28, 87);
            this.pictureboxFLY.Name = "pictureboxFLY";
            this.pictureboxFLY.Size = new System.Drawing.Size(33, 37);
            this.pictureboxFLY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxFLY.TabIndex = 8;
            this.pictureboxFLY.TabStop = false;
            // 
            // pictureboxLogo
            // 
            this.pictureboxLogo.Image = global::bgclicker.Properties.Resources.logo;
            this.pictureboxLogo.Location = new System.Drawing.Point(12, 8);
            this.pictureboxLogo.Name = "pictureboxLogo";
            this.pictureboxLogo.Size = new System.Drawing.Size(60, 67);
            this.pictureboxLogo.TabIndex = 7;
            this.pictureboxLogo.TabStop = false;
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 130);
            this.Controls.Add(this.pictureboxFLY);
            this.Controls.Add(this.pictureboxLogo);
            this.Controls.Add(this.linkHomepage);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.PictureBox pictureboxLogo;
        private System.Windows.Forms.LinkLabel linkHomepage;
        private System.Windows.Forms.PictureBox pictureboxFLY;
    }
}