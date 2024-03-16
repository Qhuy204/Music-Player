namespace MusicPlayer
{
    partial class Frm_Music
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Music));
            this.pntitlebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInternet = new CustomButton.CustomButton();
            this.btnThisdevice = new CustomButton.CustomButton();
            this.btnPlaylst = new CustomButton.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHome = new CustomButton.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSong_name = new System.Windows.Forms.Label();
            this.btnSkipleft = new System.Windows.Forms.Button();
            this.volumebar = new MetroFramework.Controls.MetroTrackBar();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnSkipright = new System.Windows.Forms.Button();
            this.pnImage = new System.Windows.Forms.Panel();
            this.trackbar = new MetroFramework.Controls.MetroTrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnAvatar = new CustomButton.CustomButton();
            this.lblName = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSongtitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dgvplay = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnX = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.pntitlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnPlay.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.userMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplay)).BeginInit();
            this.pnX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pntitlebar
            // 
            this.pntitlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pntitlebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pntitlebar.BackColor = System.Drawing.Color.Black;
            this.pntitlebar.Controls.Add(this.label1);
            this.pntitlebar.Controls.Add(this.panel1);
            this.pntitlebar.Controls.Add(this.btnShowMenu);
            this.pntitlebar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pntitlebar.Location = new System.Drawing.Point(-3, 0);
            this.pntitlebar.Name = "pntitlebar";
            this.pntitlebar.Size = new System.Drawing.Size(1372, 41);
            this.pntitlebar.TabIndex = 0;
            this.pntitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Music_MouseDown);
            this.pntitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Music_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "MusicPlayer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(1186, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnSize
            // 
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSize.Image = ((System.Drawing.Image)(resources.GetObject("btnSize.Image")));
            this.btnSize.Location = new System.Drawing.Point(87, -3);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(43, 41);
            this.btnSize.TabIndex = 1;
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(136, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(38, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 41);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackColor = System.Drawing.Color.Black;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMenu.Image")));
            this.btnShowMenu.Location = new System.Drawing.Point(3, 0);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(43, 41);
            this.btnShowMenu.TabIndex = 1;
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(122, 114);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Controls.Add(this.label9);
            this.pnMenu.Controls.Add(this.label8);
            this.pnMenu.Controls.Add(this.label6);
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Controls.Add(this.btnInternet);
            this.pnMenu.Controls.Add(this.btnThisdevice);
            this.pnMenu.Controls.Add(this.btnPlaylst);
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Location = new System.Drawing.Point(0, 33);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(244, 691);
            this.pnMenu.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(185, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "     ";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(185, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "     ";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(185, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "     ";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(185, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "     ";
            this.label5.Visible = false;
            // 
            // btnInternet
            // 
            this.btnInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnInternet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnInternet.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnInternet.BorderRadius = 20;
            this.btnInternet.BorderSize = 0;
            this.btnInternet.FlatAppearance.BorderSize = 0;
            this.btnInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternet.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnInternet.ForeColor = System.Drawing.Color.SlateGray;
            this.btnInternet.Location = new System.Drawing.Point(35, 482);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(179, 44);
            this.btnInternet.TabIndex = 4;
            this.btnInternet.Text = "Internet";
            this.btnInternet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternet.TextColor = System.Drawing.Color.SlateGray;
            this.btnInternet.UseVisualStyleBackColor = false;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnThisdevice
            // 
            this.btnThisdevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnThisdevice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnThisdevice.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnThisdevice.BorderRadius = 20;
            this.btnThisdevice.BorderSize = 0;
            this.btnThisdevice.FlatAppearance.BorderSize = 0;
            this.btnThisdevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisdevice.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnThisdevice.ForeColor = System.Drawing.Color.SlateGray;
            this.btnThisdevice.Location = new System.Drawing.Point(35, 415);
            this.btnThisdevice.Name = "btnThisdevice";
            this.btnThisdevice.Size = new System.Drawing.Size(179, 44);
            this.btnThisdevice.TabIndex = 3;
            this.btnThisdevice.Text = "This Device";
            this.btnThisdevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThisdevice.TextColor = System.Drawing.Color.SlateGray;
            this.btnThisdevice.UseVisualStyleBackColor = false;
            this.btnThisdevice.Click += new System.EventHandler(this.btnThisdevice_Click);
            // 
            // btnPlaylst
            // 
            this.btnPlaylst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnPlaylst.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnPlaylst.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPlaylst.BorderRadius = 20;
            this.btnPlaylst.BorderSize = 0;
            this.btnPlaylst.FlatAppearance.BorderSize = 0;
            this.btnPlaylst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylst.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnPlaylst.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPlaylst.Location = new System.Drawing.Point(35, 277);
            this.btnPlaylst.Name = "btnPlaylst";
            this.btnPlaylst.Size = new System.Drawing.Size(179, 46);
            this.btnPlaylst.TabIndex = 2;
            this.btnPlaylst.Text = "Playlist";
            this.btnPlaylst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylst.TextColor = System.Drawing.Color.SlateGray;
            this.btnPlaylst.UseVisualStyleBackColor = false;
            this.btnPlaylst.Click += new System.EventHandler(this.btnPlaylst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(50, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "EXPLORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "LIBRARY";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnHome.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnHome.BorderRadius = 20;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHome.Location = new System.Drawing.Point(35, 210);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextColor = System.Drawing.Color.SlateGray;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MUSICPLAYER";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(67, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 93);
            this.panel2.TabIndex = 0;
            // 
            // pnPlay
            // 
            this.pnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPlay.Controls.Add(this.lblTime);
            this.pnPlay.Controls.Add(this.lblTimeRemaining);
            this.pnPlay.Controls.Add(this.lblArtist);
            this.pnPlay.Controls.Add(this.lblSong_name);
            this.pnPlay.Controls.Add(this.btnSkipleft);
            this.pnPlay.Controls.Add(this.volumebar);
            this.pnPlay.Controls.Add(this.btnVolume);
            this.pnPlay.Controls.Add(this.btnSkipright);
            this.pnPlay.Controls.Add(this.pnImage);
            this.pnPlay.Controls.Add(this.trackbar);
            this.pnPlay.Controls.Add(this.btnPlay);
            this.pnPlay.Controls.Add(this.btnPause);
            this.pnPlay.Controls.Add(this.btnMute);
            this.pnPlay.Location = new System.Drawing.Point(-3, 691);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(1372, 112);
            this.pnPlay.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(378, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(940, 71);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(50, 19);
            this.lblTimeRemaining.TabIndex = 4;
            this.lblTimeRemaining.Text = "00:00";
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(87, 53);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 19);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artist";
            // 
            // lblSong_name
            // 
            this.lblSong_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSong_name.AutoSize = true;
            this.lblSong_name.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong_name.Location = new System.Drawing.Point(87, 30);
            this.lblSong_name.Name = "lblSong_name";
            this.lblSong_name.Size = new System.Drawing.Size(94, 20);
            this.lblSong_name.TabIndex = 3;
            this.lblSong_name.Text = "Song Title";
            // 
            // btnSkipleft
            // 
            this.btnSkipleft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSkipleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipleft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnSkipleft.Image = ((System.Drawing.Image)(resources.GetObject("btnSkipleft.Image")));
            this.btnSkipleft.Location = new System.Drawing.Point(602, 20);
            this.btnSkipleft.Name = "btnSkipleft";
            this.btnSkipleft.Size = new System.Drawing.Size(42, 40);
            this.btnSkipleft.TabIndex = 1;
            this.btnSkipleft.UseVisualStyleBackColor = true;
            this.btnSkipleft.Click += new System.EventHandler(this.btnSkipleft_Click);
            // 
            // volumebar
            // 
            this.volumebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.volumebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.volumebar.Location = new System.Drawing.Point(1233, 74);
            this.volumebar.Name = "volumebar";
            this.volumebar.Size = new System.Drawing.Size(110, 11);
            this.volumebar.TabIndex = 0;
            this.volumebar.Text = "metroTrackBar1";
            this.volumebar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumebar_Scroll);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.Location = new System.Drawing.Point(1185, 60);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(42, 40);
            this.btnVolume.TabIndex = 5;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnSkipright
            // 
            this.btnSkipright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSkipright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnSkipright.Image = ((System.Drawing.Image)(resources.GetObject("btnSkipright.Image")));
            this.btnSkipright.Location = new System.Drawing.Point(729, 20);
            this.btnSkipright.Name = "btnSkipright";
            this.btnSkipright.Size = new System.Drawing.Size(42, 40);
            this.btnSkipright.TabIndex = 3;
            this.btnSkipright.UseVisualStyleBackColor = true;
            this.btnSkipright.Click += new System.EventHandler(this.btnSkipright_Click);
            // 
            // pnImage
            // 
            this.pnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnImage.BackgroundImage")));
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnImage.Location = new System.Drawing.Point(14, 20);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(67, 64);
            this.pnImage.TabIndex = 1;
            // 
            // trackbar
            // 
            this.trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.trackbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.trackbar.Location = new System.Drawing.Point(438, 78);
            this.trackbar.Name = "trackbar";
            this.trackbar.Size = new System.Drawing.Size(496, 11);
            this.trackbar.TabIndex = 0;
            this.trackbar.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            this.trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbar_Scroll);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(650, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 61);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(650, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(73, 61);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnMute
            // 
            this.btnMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.Location = new System.Drawing.Point(1185, 60);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(42, 40);
            this.btnMute.TabIndex = 2;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSearch.Controls.Add(this.btnAvatar);
            this.pnSearch.Controls.Add(this.lblName);
            this.pnSearch.Location = new System.Drawing.Point(244, 33);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1122, 98);
            this.pnSearch.TabIndex = 3;
            // 
            // btnAvatar
            // 
            this.btnAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnAvatar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvatar.BackgroundImage")));
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvatar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAvatar.BorderRadius = 28;
            this.btnAvatar.BorderSize = 0;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.Location = new System.Drawing.Point(1045, 25);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(58, 54);
            this.btnAvatar.TabIndex = 2;
            this.btnAvatar.TextColor = System.Drawing.Color.White;
            this.btnAvatar.UseVisualStyleBackColor = false;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblName.Location = new System.Drawing.Point(41, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 33);
            this.lblName.TabIndex = 1;
            // 
            // pnContent
            // 
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContent.Location = new System.Drawing.Point(245, 128);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1124, 568);
            this.pnContent.TabIndex = 6;
            // 
            // userMenu
            // 
            this.userMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account,
            this.LogOut});
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(120, 48);
            // 
            // Account
            // 
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(119, 22);
            this.Account.Text = "Account";
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(119, 22);
            this.LogOut.Text = "Log out";
            this.LogOut.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Song Title";
            // 
            // lblSongtitle
            // 
            this.lblSongtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongtitle.AutoSize = true;
            this.lblSongtitle.Font = new System.Drawing.Font("Rockwell", 15F);
            this.lblSongtitle.Location = new System.Drawing.Point(24, 48);
            this.lblSongtitle.Name = "lblSongtitle";
            this.lblSongtitle.Size = new System.Drawing.Size(50, 22);
            this.lblSongtitle.TabIndex = 5;
            this.lblSongtitle.Text = "Title";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(23, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Artist";
            // 
            // lblArtists
            // 
            this.lblArtists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Rockwell", 15F);
            this.lblArtists.Location = new System.Drawing.Point(24, 111);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(59, 22);
            this.lblArtists.TabIndex = 5;
            this.lblArtists.Text = "Artist";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(23, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Duration";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Rockwell", 15F);
            this.lblDuration.Location = new System.Drawing.Point(24, 174);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(89, 22);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            // 
            // dgvplay
            // 
            this.dgvplay.AllowUserToAddRows = false;
            this.dgvplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.artist_name,
            this.duration});
            this.dgvplay.Location = new System.Drawing.Point(933, 137);
            this.dgvplay.Name = "dgvplay";
            this.dgvplay.ReadOnly = true;
            this.dgvplay.Size = new System.Drawing.Size(420, 548);
            this.dgvplay.TabIndex = 6;
            this.dgvplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplay_CellContentClick);
            this.dgvplay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplay_CellContentClick);
            this.dgvplay.SelectionChanged += new System.EventHandler(this.dgvplay_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Title";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // artist_name
            // 
            this.artist_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artist_name.DataPropertyName = "artist_name";
            this.artist_name.HeaderText = "Artist";
            this.artist_name.Name = "artist_name";
            this.artist_name.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 98;
            // 
            // pnX
            // 
            this.pnX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnX.BackColor = System.Drawing.SystemColors.Control;
            this.pnX.Controls.Add(this.pbImage);
            this.pnX.Controls.Add(this.lblDuration);
            this.pnX.Controls.Add(this.lblArtists);
            this.pnX.Controls.Add(this.lblSongtitle);
            this.pnX.Controls.Add(this.label13);
            this.pnX.Controls.Add(this.label11);
            this.pnX.Controls.Add(this.label7);
            this.pnX.Location = new System.Drawing.Point(255, 137);
            this.pnX.Name = "pnX";
            this.pnX.Size = new System.Drawing.Size(660, 548);
            this.pnX.TabIndex = 7;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(280, 124);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(363, 409);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 10;
            this.elipseControl1.TargetControl = this;
            // 
            // Frm_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1365, 802);
            this.Controls.Add(this.pntitlebar);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnPlay);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnX);
            this.Controls.Add(this.dgvplay);
            this.Controls.Add(this.pnMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Music_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Music_Load);
            this.pntitlebar.ResumeLayout(false);
            this.pntitlebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnPlay.ResumeLayout(false);
            this.pnPlay.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.userMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplay)).EndInit();
            this.pnX.ResumeLayout(false);
            this.pnX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pntitlebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnPlay;
        private System.Windows.Forms.Panel pnSearch;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomButton.CustomButton btnHome;
        private CustomButton.CustomButton btnInternet;
        private CustomButton.CustomButton btnThisdevice;
        private CustomButton.CustomButton btnPlaylst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.Panel pnContent;
        private MetroFramework.Controls.MetroTrackBar trackbar;
        private System.Windows.Forms.Panel pnImage;
        private MetroFramework.Controls.MetroTrackBar volumebar;
        private System.Windows.Forms.Button btnSkipleft;
        private System.Windows.Forms.Button btnSkipright;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSong_name;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblSongtitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgvplay;
        private System.Windows.Forms.Panel pnX;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private CustomButton.CustomButton btnAvatar;
    }
}