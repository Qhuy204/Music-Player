namespace MusicPlayer
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPlaylist = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRemoveplst = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFind = new System.Windows.Forms.DataGridView();
            this.lblplsName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.ID_Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Song_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New playlist";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist name : ";
            // 
            // cbbPlaylist
            // 
            this.cbbPlaylist.FormattingEnabled = true;
            this.cbbPlaylist.Location = new System.Drawing.Point(130, 62);
            this.cbbPlaylist.Name = "cbbPlaylist";
            this.cbbPlaylist.Size = new System.Drawing.Size(196, 27);
            this.cbbPlaylist.TabIndex = 2;
            this.cbbPlaylist.SelectedIndexChanged += new System.EventHandler(this.cbbPlaylist_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.artist_name,
            this.duration});
            this.dataGridView1.Location = new System.Drawing.Point(11, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(718, 425);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Title";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 65;
            // 
            // artist_name
            // 
            this.artist_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.artist_name.DataPropertyName = "artist_name";
            this.artist_name.HeaderText = "Artist";
            this.artist_name.Name = "artist_name";
            this.artist_name.ReadOnly = true;
            this.artist_name.Width = 73;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(444, 53);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 41);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(535, 54);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(85, 41);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRemoveplst
            // 
            this.btnRemoveplst.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveplst.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveplst.Image")));
            this.btnRemoveplst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveplst.Location = new System.Drawing.Point(159, 12);
            this.btnRemoveplst.Name = "btnRemoveplst";
            this.btnRemoveplst.Size = new System.Drawing.Size(167, 38);
            this.btnRemoveplst.TabIndex = 0;
            this.btnRemoveplst.Text = "Remove playlist";
            this.btnRemoveplst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveplst.UseVisualStyleBackColor = true;
            this.btnRemoveplst.Click += new System.EventHandler(this.btnRemoveplst_Click);
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Image = ((System.Drawing.Image)(resources.GetObject("btnRename.Image")));
            this.btnRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRename.Location = new System.Drawing.Point(332, 12);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(167, 38);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename playlist";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.btnsearch);
            this.pnAdd.Controls.Add(this.btnImport);
            this.pnAdd.Controls.Add(this.txtArtist);
            this.pnAdd.Controls.Add(this.txtSong);
            this.pnAdd.Controls.Add(this.label5);
            this.pnAdd.Controls.Add(this.label4);
            this.pnAdd.Controls.Add(this.dgvFind);
            this.pnAdd.Controls.Add(this.lblplsName);
            this.pnAdd.Controls.Add(this.label3);
            this.pnAdd.Controls.Add(this.label2);
            this.pnAdd.Controls.Add(this.btnBack);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(742, 545);
            this.pnAdd.TabIndex = 5;
            this.pnAdd.Visible = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(444, 126);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(122, 38);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(584, 126);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(122, 38);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(235, 133);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(172, 26);
            this.txtArtist.TabIndex = 6;
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(36, 133);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(172, 26);
            this.txtSong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14F);
            this.label5.Location = new System.Drawing.Point(231, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Artist name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14F);
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Song name";
            // 
            // dgvFind
            // 
            this.dgvFind.AllowUserToAddRows = false;
            this.dgvFind.AllowUserToDeleteRows = false;
            this.dgvFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFind.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgvFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Song,
            this.song_name,
            this.song_artist,
            this.Song_duration});
            this.dgvFind.Location = new System.Drawing.Point(14, 175);
            this.dgvFind.Name = "dgvFind";
            this.dgvFind.ReadOnly = true;
            this.dgvFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFind.Size = new System.Drawing.Size(714, 358);
            this.dgvFind.TabIndex = 4;
            // 
            // lblplsName
            // 
            this.lblplsName.AutoSize = true;
            this.lblplsName.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.lblplsName.Location = new System.Drawing.Point(324, 19);
            this.lblplsName.Name = "lblplsName";
            this.lblplsName.Size = new System.Drawing.Size(0, 27);
            this.lblplsName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Playlist name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Let\'s find something for your playlist : ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ID_Song
            // 
            this.ID_Song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID_Song.DataPropertyName = "ID";
            this.ID_Song.HeaderText = "ID";
            this.ID_Song.Name = "ID_Song";
            this.ID_Song.ReadOnly = true;
            this.ID_Song.Width = 51;
            // 
            // song_name
            // 
            this.song_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song_name.DataPropertyName = "name";
            this.song_name.HeaderText = "Name";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            // 
            // song_artist
            // 
            this.song_artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song_artist.DataPropertyName = "artist_name";
            this.song_artist.HeaderText = "Artist";
            this.song_artist.Name = "song_artist";
            this.song_artist.ReadOnly = true;
            // 
            // Song_duration
            // 
            this.Song_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Song_duration.DataPropertyName = "Duration";
            this.Song_duration.HeaderText = "Duration";
            this.Song_duration.Name = "Song_duration";
            this.Song_duration.ReadOnly = true;
            this.Song_duration.Width = 98;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(742, 545);
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnRemoveplst);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPlaylist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRemoveplst;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFind;
        private System.Windows.Forms.Label lblplsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song_duration;
    }
}