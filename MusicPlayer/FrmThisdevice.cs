using MusicPlayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace MusicPlayer
{
    public partial class FrmThisdevice : Form
    {
        private Frm_Music musicForm;

        public FrmThisdevice()
        {
            InitializeComponent();
        }

        private void FrmThisdevice_Load(object sender, EventArgs e)
        {
            LoaddgvList();
        }

        void LoaddgvList()
        {
            string query = "SELECT ID, name, artist_name, FORMAT(DATEADD(SECOND, duration, 0), 'mm:ss') AS duration FROM SONGS";
            dgvlist.DataSource = DataHelper.GetDataTable(query);
        }

        public void dgvlist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvlist.Columns[e.ColumnIndex].Name == "clPlay" && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvlist.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    buttonCell.Value = "Play";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public void dgvlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvlist.Columns["clPlay"].Index)
                {
                    DataGridViewRow selectedRow = dgvlist.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    string name = selectedRow.Cells["name"].Value.ToString();
                    string artist = selectedRow.Cells["artist_name"].Value.ToString();
                    string duration = selectedRow.Cells["duration"].Value.ToString();

                    Frm_Music musicForm = this.ParentForm as Frm_Music;
                    if (musicForm != null)
                    {
                        musicForm.UpdateDGVPlay(id, name, artist, duration);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK);
            }
        }

        String[] paths, files;
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Audio Files|*.mp3;*.wav;*.flac;*.aac;*.ogg";


            if (open.ShowDialog() == DialogResult.OK)
            {
                files = open.SafeFileNames;
                paths = open.FileNames;

                // Tạo danh sách các bài hát từ danh sách các file
                var songs = new List<Song>();
                for (int i = 0; i < files.Length; i++)
                {
                    // Lấy thông tin về bài hát từ file
                    var song = GetSongInfo(paths[i], files[i]);

                    // Thêm bài hát vào danh sách
                    songs.Add(song);
                }

                // Nhập các bài hát vào database
                ImportSongs(songs);
            }
            LoaddgvList();
        }

        public static void ImportSongs(List<Song> songs)
        {
            var connection = new SqlConnection(@"Data Source=QHUY\SQLEXPRESS;Initial Catalog=MusicPlayer;Integrated Security=True");
            connection.Open();
            for (int i = 0; i < songs.Count; i++)
            {
                string query = "SELECT MAX(ID) AS MaxID FROM SONGS";
                SqlCommand cmd = new SqlCommand(query, connection);
                int lastID = 0;

                // Lấy giá trị ID lớn nhất từ cơ sở dữ liệu
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        lastID = reader.GetInt32(0);
                    }
                }
                int ID = lastID + 1;
                string queryz = $"INSERT INTO Songs (ID, name, artist_name, duration, path) VALUES ({ID}, N'{songs[i].Name}', N'{songs[i].ArtistName}', {songs[i].Duration}, N'{songs[i].Path}')";

                DataHelper.ThucThiSQL(queryz);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvlist.SelectedCells.Count > 0) // Kiểm tra xem có hàng được chọn không
                {
                    int selectedRowIndex = dgvlist.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvlist.Rows[selectedRowIndex];

                    // Lấy giá trị của cột ID từ hàng được chọn
                    if (selectedRow.Cells["ID"].Value != null)
                    {
                        int idToDelete = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        // Hiển thị MessageBox xác nhận xóa
                        DialogResult result = MessageBox.Show("Are you sure? It will be permanently deleted", "Notice", MessageBoxButtons.YesNo);

                        // Xóa dữ liệu nếu người dùng chọn Yes
                        if (result == DialogResult.Yes)
                        {
                            string query = $"DELETE FROM SONGS WHERE ID = {idToDelete}";
                            DataHelper.ThucThiSQL(query);
                            LoaddgvList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                return;
            }
            
        }

        private Song GetSongInfo(string filePath, string fileName)
        {
            Song song = null;
            int duration = 0;
            byte[] imageData;
            try
            {
                using (var file = TagLib.File.Create(filePath)) // Sử dụng using để đảm bảo đóng file
                {
                    if (file != null)
                    {
                        // Lấy thông tin từ các tag của tệp âm thanh
                        string title;
                        if (!string.IsNullOrEmpty(file.Tag.Title))
                        {
                            title = file.Tag.Title;
                        }
                        else
                        {
                            title = fileName;
                        }
                        string artist;
                        if (!string.IsNullOrEmpty(file.Tag.FirstPerformer))
                        {
                            artist = file.Tag.FirstPerformer;
                        }
                        else
                        {
                            artist = "Unknown Artist";
                        }
                        TimeSpan durationz = file.Properties.Duration;
                        duration = (int)durationz.TotalSeconds;
                        string path = filePath;
                        song = new Song
                        {
                            Name = title,
                            ArtistName = artist,
                            Duration = duration,
                            Path = filePath,
                        };
                    }
                    else
                    {
                        Console.WriteLine("Cannot read metadata.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading metadata: {0}", ex.Message);
            }
            return song;
        }

    }
}
