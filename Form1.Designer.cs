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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.mainTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblTrackTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbAlbumArt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.trackBarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.завантажитиПіснюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlaylistContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.gridPlaylist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelPlaylistContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkViolet;
            this.panelSideMenu.Controls.Add(this.mainTrackBar);
            this.panelSideMenu.Controls.Add(this.lblTrackTitle);
            this.panelSideMenu.Controls.Add(this.pbAlbumArt);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(592, 737);
            this.panelSideMenu.TabIndex = 0;
            // 
            // mainTrackBar
            // 
            this.mainTrackBar.BackColor = System.Drawing.Color.DarkOrchid;
            this.mainTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainTrackBar.Location = new System.Drawing.Point(0, 701);
            this.mainTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTrackBar.Maximum = 1000;
            this.mainTrackBar.Name = "mainTrackBar";
            this.mainTrackBar.Size = new System.Drawing.Size(592, 36);
            this.mainTrackBar.TabIndex = 2;
            this.mainTrackBar.ThumbColor = System.Drawing.Color.Black;
            this.mainTrackBar.Value = 0;
            this.mainTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mainTrackBar_Scroll);
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrackTitle.Location = new System.Drawing.Point(204, 273);
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
<<<<<<< HEAD
            this.pbAlbumArt.Location = new System.Drawing.Point(177, 29);
=======
            this.pbAlbumArt.Location = new System.Drawing.Point(177, 30);
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
            this.pbAlbumArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAlbumArt.Name = "pbAlbumArt";
            this.pbAlbumArt.Size = new System.Drawing.Size(225, 234);
            this.pbAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbumArt.TabIndex = 0;
            this.pbAlbumArt.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(195, 147);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(450, 36);
            this.trackBarVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.trackBarVolume.TabIndex = 2;
            this.trackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarVolume_Scroll);
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
            this.btnPrev.Location = new System.Drawing.Point(195, 9);
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
            this.btnPlay.Location = new System.Drawing.Point(366, 9);
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
            this.btnNext.Location = new System.Drawing.Point(532, 9);
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(100, 125);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(72, 72);
            this.guna2CircleButton1.TabIndex = 6;
            this.guna2CircleButton1.Text = "";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
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
            this.guna2Panel1.Size = new System.Drawing.Size(796, 202);
            this.guna2Panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантажитиПіснюToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.loadPlaylistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
            this.menuStrip1.Size = new System.Drawing.Size(1388, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // завантажитиПіснюToolStripMenuItem
            // 
            this.завантажитиПіснюToolStripMenuItem.Name = "завантажитиПіснюToolStripMenuItem";
            this.завантажитиПіснюToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.завантажитиПіснюToolStripMenuItem.Text = "Завантажити пісню";
            this.завантажитиПіснюToolStripMenuItem.Click += new System.EventHandler(this.завантажитиПіснюToolStripMenuItem_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.savePlaylistToolStripMenuItem.Text = "Зберегти плейлист";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // loadPlaylistToolStripMenuItem
            // 
            this.loadPlaylistToolStripMenuItem.Name = "loadPlaylistToolStripMenuItem";
            this.loadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(253, 36);
            this.loadPlaylistToolStripMenuItem.Text = "Загрузити плейлист";
            this.loadPlaylistToolStripMenuItem.Click += new System.EventHandler(this.loadPlaylistToolStripMenuItem_Click);
            // 
            // panelPlaylistContainer
            // 
            this.panelPlaylistContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelPlaylistContainer.Controls.Add(this.gridPlaylist);
            this.panelPlaylistContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaylistContainer.Location = new System.Drawing.Point(592, 40);
            this.panelPlaylistContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPlaylistContainer.Name = "panelPlaylistContainer";
            this.panelPlaylistContainer.Size = new System.Drawing.Size(796, 535);
            this.panelPlaylistContainer.TabIndex = 4;
            // 
            // gridPlaylist
            // 
            this.gridPlaylist.AllowUserToAddRows = false;
            this.gridPlaylist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridPlaylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridPlaylist.ColumnHeadersHeight = 30;
            this.gridPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colTitle,
            this.colArtist,
            this.colDuration});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPlaylist.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridPlaylist.Location = new System.Drawing.Point(0, 0);
            this.gridPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridPlaylist.MultiSelect = false;
            this.gridPlaylist.Name = "gridPlaylist";
            this.gridPlaylist.ReadOnly = true;
            this.gridPlaylist.RowHeadersVisible = false;
            this.gridPlaylist.RowHeadersWidth = 51;
            this.gridPlaylist.RowTemplate.Height = 40;
            this.gridPlaylist.Size = new System.Drawing.Size(796, 535);
            this.gridPlaylist.TabIndex = 0;
            this.gridPlaylist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.gridPlaylist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridPlaylist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPlaylist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPlaylist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPlaylist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPlaylist.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridPlaylist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridPlaylist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gridPlaylist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPlaylist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridPlaylist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPlaylist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPlaylist.ThemeStyle.HeaderStyle.Height = 30;
            this.gridPlaylist.ThemeStyle.ReadOnly = true;
            this.gridPlaylist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gridPlaylist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPlaylist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridPlaylist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gridPlaylist.ThemeStyle.RowsStyle.Height = 40;
            this.gridPlaylist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.gridPlaylist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // colNumber
            // 
            this.colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumber.FillWeight = 85.56149F;
            this.colNumber.HeaderText = "#";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 77;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.FillWeight = 180.7117F;
            this.colTitle.HeaderText = "Назва";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colArtist
            // 
            this.colArtist.FillWeight = 113.8836F;
            this.colArtist.HeaderText = "Виконавець";
            this.colArtist.MinimumWidth = 6;
            this.colArtist.Name = "colArtist";
            this.colArtist.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.FillWeight = 19.84314F;
            this.colDuration.HeaderText = "Час";
            this.colDuration.MinimumWidth = 6;
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 777);
            this.Controls.Add(this.panelPlaylistContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BetterSpotify";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPlaylistContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завантажитиПіснюToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TrackBar mainTrackBar;
        private Guna.UI2.WinForms.Guna2Panel panelPlaylistContainer;
        private Guna.UI2.WinForms.Guna2DataGridView gridPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem;
    }
}

