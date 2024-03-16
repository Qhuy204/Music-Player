using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MusicPlayer
{
    public partial class Playlist : Form
    {

        public event EventHandler<DataGridViewEventArgs> PlayButtonClicked;

        public Playlist()
        {
            InitializeComponent();
            LoadcbbPlaylist();
            Loaddgv();
        }

        public string user;
        private void btnNew_Click(object sender, EventArgs e)
        {
            string playlistName = ShowDialog("Playlist Name:", "Create Playlist");
            if (!string.IsNullOrEmpty(playlistName))
            {
                int ownerId = GetCurrentUserId();
                int playlistId = SavePlaylistToDatabase(playlistName, ownerId);
                LoadcbbPlaylist();
                Loaddgv();
            }
        }

        private string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 70, Height = 30 };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);

            // Đặt vị trí ban đầu của form prompt
            prompt.StartPosition = FormStartPosition.Manual;
            int x = btnNew.PointToScreen(Point.Empty).X;
            int y = btnNew.PointToScreen(Point.Empty).Y + btnNew.Height;
            prompt.Location = new Point(x, y);

            prompt.ShowDialog();
            return textBox.Text;
        }

        private int GetCurrentUserId()
        {
            string query = $"SELECT * FROM USERS WHERE username = '{user.Trim()}'";
            DataTable dt = DataHelper.GetDataTable(query);
            int userId;
            userId = int.Parse(dt.Rows[0]["ID"].ToString());
            return userId;
        }

        private int SavePlaylistToDatabase(string playlistName, int ownerId)
        {
            try
            {
                var connection = new SqlConnection(@"Data Source=QHUY\SQLEXPRESS;Initial Catalog=MusicPlayer;Integrated Security=True");
                connection.Open();
                string query = "SELECT MAX(ID) AS MaxID FROM PLAYLISTS";
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
                string queryz = $"INSERT INTO PLAYLISTS (ID, name, owner_id) VALUES ({ID}, N'{playlistName}', '{ownerId}')";
                DataHelper.ThucThiSQL(queryz);
                return ID;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save playlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        void LoadcbbPlaylist()
        {
            string source = @"temp.txt";
            StreamReader sr = new StreamReader(source);
            user = sr.ReadLine();

            string query = $"SELECT LST.name FROM PLAYLISTS LST INNER JOIN USERS U ON LST.owner_id = U.ID WHERE U.username = '{user.Trim()}'";
            cbbPlaylist.DataSource = DataHelper.GetDataTable(query);
            cbbPlaylist.DisplayMember = "name";
            Loaddgv();
            sr.Close();
        }

        void Loaddgv()
        {
            string query = $"SELECT S.ID, S.name, S.artist_name, FORMAT(DATEADD(SECOND, S.duration, 0), 'mm:ss') as duration FROM SONGS S INNER JOIN PLAYLIST_SONGS PLS ON S.ID = PLS.Songs_ID INNER JOIN PLAYLISTS PL ON PL.ID = PLS.Playlist_ID INNER JOIN USERS U ON U.ID = PL.owner_id WHERE PL.name = '{cbbPlaylist.Text.Trim()}' AND U.username = '{user.Trim()}'";
            dataGridView1.DataSource = DataHelper.GetDataTable(query);
        }

        void LoaddgvFind()
        {
            string query = $"Select * from TimKiemBaiHat(N'{txtSong.Text}', N'{txtArtist.Text}')";
            dgvFind.DataSource = DataHelper.GetDataTable(query);
        }

        private void btnRemoveplst_Click(object sender, EventArgs e)
        {
            string query = $"DELETE PLST FROM PLAYLISTS PLST INNER JOIN USERS U ON PLST.owner_id = U.ID WHERE PLST.name = '{cbbPlaylist.Text.Trim()}' AND U.username = '{user}'";
            DataHelper.ThucThiSQL(query);
            LoadcbbPlaylist();
        }

        private void cbbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaddgv();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string newname = ShowDialog("New name: ", "Rename");
            if (!string.IsNullOrEmpty(newname))
            {
                string query = $"UPDATE PLAYLISTS SET name = N'{newname}' where name = '{cbbPlaylist.Text.Trim()}'";
                DataHelper.ThucThiSQL(query);
                LoadcbbPlaylist();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a playlist!", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                pnAdd.Visible = true;
                LoaddgvFind();
                lblplsName.Text = cbbPlaylist.Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0) // Kiểm tra xem có hàng được chọn không
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Lấy giá trị của cột ID từ hàng được chọn
                if (selectedRow.Cells["ID"].Value != null)
                {
                    int idToDelete = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    // Hiển thị MessageBox xác nhận xóa
                    DialogResult result = MessageBox.Show("Are you sure? It will be permanently deleted", "Notice", MessageBoxButtons.YesNo);

                    // Xóa dữ liệu nếu người dùng chọn Yes
                    if (result == DialogResult.Yes)
                    {
                        int selectedId = (int)dataGridView1.SelectedCells[0].Value;
                        string query = $"DELETE PLS FROM PLAYLIST_SONGS PLS INNER JOIN PLAYLISTS PL ON PL.ID = PLS.Playlist_ID INNER JOIN USERS U ON U.ID = PL.owner_id WHERE PL.name = N'{cbbPlaylist.Text.Trim()}' AND PLS.Songs_ID = {selectedId} AND U.username = '{user}'";
                        DataHelper.ThucThiSQL(query);
                        Loaddgv();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete!", "Notice", MessageBoxButtons.OK);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ DataGridView1
            DataGridView dgv = dataGridView1;

            // Kích hoạt sự kiện và truyền dữ liệu đi (DataGridView1) cho form cha
            PlayButtonClicked?.Invoke(this, new DataGridViewEventArgs(dgv));
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            cbbPlaylist.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnAdd.Visible = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoaddgvFind();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvFind.SelectedRows[0].Cells["ID_Song"].Value);

            // Retrieve the ID of the playlist where name matches the selected item in the combo box
            string playlistQuery = $"SELECT TOP 1 PLST.ID FROM PLAYLISTS PLST INNER JOIN USERS U ON U.ID = PLST.owner_id WHERE PLST.name = N'{cbbPlaylist.Text.Trim()}' AND U.username = '{user.Trim()}'";

            // Retrieve the maximum PlaylistSong_ID and increment it by 1
            string maxPlaylistSongIDQuery = "SELECT ISNULL(MAX(PlaylistSong_ID), 0) + 1 FROM PLAYLIST_SONGS";

            string query = $"INSERT INTO PLAYLIST_SONGS VALUES(({maxPlaylistSongIDQuery}), ({playlistQuery}), {selectedID})";

            DataHelper.ThucThiSQL(query);
            Loaddgv();

            try
            {
                // Your additional code here, if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public class DataGridViewEventArgs : EventArgs
    {
        // Thêm thuộc tính hoặc trường để chứa dữ liệu từ DataGridView của form con
        public DataGridView DataGridViewFromChildForm { get; set; }

        // Constructor để khởi tạo lớp DataGridViewEventArgs với dữ liệu
        public DataGridViewEventArgs(DataGridView dataGridView)
        {
            DataGridViewFromChildForm = dataGridView;
        }
    }


}
