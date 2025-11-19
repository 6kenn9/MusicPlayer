namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrackTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbAlbumArt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.trackBarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkViolet;
            this.panelSideMenu.Controls.Add(this.lblTrackTitle);
            this.panelSideMenu.Controls.Add(this.pbAlbumArt);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(592, 777);
            this.panelSideMenu.TabIndex = 0;
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrackTitle.Location = new System.Drawing.Point(204, 286);
            this.lblTrackTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Size = new System.Drawing.Size(172, 39);
            this.lblTrackTitle.TabIndex = 1;
            this.lblTrackTitle.Text = "Назва пісні";
            // 
            // pbAlbumArt
            // 
            this.pbAlbumArt.Image = ((System.Drawing.Image)(resources.GetObject("pbAlbumArt.Image")));
            this.pbAlbumArt.ImageRotate = 0F;
            this.pbAlbumArt.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAlbumArt.InitialImage")));
            this.pbAlbumArt.Location = new System.Drawing.Point(177, 19);
            this.pbAlbumArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAlbumArt.Name = "pbAlbumArt";
            this.pbAlbumArt.Size = new System.Drawing.Size(225, 234);
            this.pbAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbumArt.TabIndex = 0;
            this.pbAlbumArt.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(136, 141);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(450, 36);
            this.trackBarVolume.TabIndex = 2;
            this.trackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // btnPrev
            // 
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(114, 5);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.Size = new System.Drawing.Size(112, 109);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnPlay.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(288, 5);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.Size = new System.Drawing.Size(112, 109);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(459, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(112, 109);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(33, 119);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(72, 72);
            this.guna2CircleButton1.TabIndex = 6;
            this.guna2CircleButton1.Text = "";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.Controls.Add(this.btnPrev);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Controls.Add(this.btnNext);
            this.guna2Panel1.Controls.Add(this.btnPlay);
            this.guna2Panel1.Controls.Add(this.trackBarVolume);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(592, 575);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(701, 202);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 777);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BetterSpotify";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSideMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAlbumArt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrackTitle;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarVolume;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlay;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

