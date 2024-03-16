using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using TagLib;
using System.Threading.Tasks;
using SpotifyExplode.Users;
using System.Data;

namespace MusicPlayer
{
    public partial class Frm_Music : Form
    {
        public WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        Timer trackBarTimer = new Timer();

        public Frm_Music()
        {
            InitializeComponent();
            InitializeEvents();
            trackbar.Value = 0;
            volumebar.Value = 30;
            volume = volumebar.Value;
        }

        private void Frm_Music_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
            string source = @"temp.txt";
            StreamReader sr = new StreamReader(source);
            string user = sr.ReadLine();
            sr.Close();
            string query = $"SELECT * FROM USERS WHERE username = '{user}'";
            DataTable dt = DataHelper.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                string path = dt.Rows[0]["profile_picture"].ToString().Trim();
                //MessageBox.Show(path);
                btnAvatar.BackgroundImage = Image.FromFile(path);
                btnAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Point MouseLocation;

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            menu.Show(btnShowMenu, new Point(5, btnShowMenu.Height));
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi MenuItem được chọn
            MenuItem clickedItem = (MenuItem)sender;
            MessageBox.Show("Bạn đã chọn: " + clickedItem.Text);
        }

        private void Account_Click(object sender, EventArgs e)
        {
            pnContent.Visible = true;
            lblName.Text = "My Information";
            OpenChildFrm(new Account());
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            try
            {
                string filePath = @"temp.txt";
                this.Hide();
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath); // Xóa tệp tin temp.txt nếu tồn tại
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message, "Logout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

        #region Loadform
        private Form curFormChild;

        private void OpenChildFrm(Form Childform)
        {
            if (curFormChild != null)
            {
                curFormChild.Close();
            }
            curFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            pnContent.Controls.Add(Childform);
            pnContent.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnContent.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lblName.Text = label3.Text + " - " + btnHome.Text.ToUpper();
        }

        private void btnPlaylst_Click(object sender, EventArgs e)
        {
            pnContent.Visible = true;
            label6.Visible = true;
            label5.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lblName.Text = label3.Text + " - " + btnPlaylst.Text.ToUpper();
            Playlist plst = new Playlist();
            OpenChildFrm(plst);
            plst.PlayButtonClicked += ChildForm_PlayButtonClicked;
        }

        private void btnThisdevice_Click(object sender, EventArgs e)
        {
            pnContent.Visible = true;
            label8.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            lblName.Text = label4.Text + " - " + btnThisdevice.Text.ToUpper();
            OpenChildFrm(new FrmThisdevice());
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            pnContent.Visible = true;
            label9.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            lblName.Text = label4.Text + " - " + btnInternet.Text.ToUpper();
            OpenChildFrm(new Frm_Search());
        }

        #endregion

        #region TitleBar


        private void btnSize_Click(object sender, EventArgs e)
        {
            if (ismax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                ismax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ismax = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ismax = false;

        //Handle Form move event
        private void Frm_Music_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void Frm_Music_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point MousePose = Control.MousePosition;
                MousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = MousePose;
            }
        }
        #endregion

        #region Region volume manager 
        private int volume;

        //2 button chỉ để hiện trạng thái
        public void btnVolume_Click(object sender, EventArgs e)
        {
            volume = volumebar.Value;
            btnMute.BringToFront();
            volumebar.Value = 0;
            player.settings.volume = volumebar.Value;
            
        }

        public void btnMute_Click(object sender, EventArgs e)
        {
            btnVolume.BringToFront();
            volumebar.Value = volume;
            player.settings.volume = volume;
        }

        private void volumebar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volumebar.Value;
            volume = volumebar.Value;
            if (volume == 0)
            {
                btnMute.BringToFront();
            }
            else
            {
                btnVolume.BringToFront();
            }
        }
        #endregion

        #region Datagridview dgvplay
        private void dgvplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvplay_SelectionChanged(sender, e);
        }

        private void dgvplay_SelectionChanged(object sender, EventArgs e)
        {
            btnPlay_Click(sender, e);
        }

        private void ChildForm_PlayButtonClicked(object sender, DataGridViewEventArgs e)
        {
            DataGridView dgv = e.DataGridViewFromChildForm;

            dgvplay.DataSource = dgv.DataSource;
        }

        public void UpdateDGVPlay(int id, string name, string artist, string duration)
        {
            dgvplay.DataSource = null;
            dgvplay.Rows.Clear();
            dgvplay.Rows.Add(id, name, artist, duration);
        }
        #endregion

        #region Get Songs thumbnail
        private byte[] GetThumbnail(string audioPath)
        {
            if (System.IO.File.Exists(audioPath))
            {
                FileInfo fileInfo = new FileInfo(audioPath);
                string extension = fileInfo.Extension.ToLower();

                switch (extension)
                {
                    case ".mp3":
                        return GetMP3Thumbnail(audioPath);
                    case ".flac":
                        return GetFLACThumbnail(audioPath);
                    // Thêm các trường hợp xử lý cho các định dạng khác (WAV, AAC, OGG, ...)
                    default:
                        throw new NotSupportedException("Unsupported audio format");
                }
            }
            else
            {
                throw new FileNotFoundException("File not found", audioPath);
            }
        }

        // Phương thức để xử lý thumbnail của file MP3
        private byte[] GetMP3Thumbnail(string audioPath)
        {
            using (var file = TagLib.File.Create(audioPath))
            {
                if (file != null)
                {
                    IPicture[] pictures = file.Tag.Pictures;
                    if (pictures.Length > 0)
                    {
                        return pictures[0].Data.Data;
                    }
                }
            }
            // Trả về ảnh trắng
            return CreateBlankImage();
        }

        // Phương thức để xử lý thumbnail của file FLAC
        private byte[] GetFLACThumbnail(string audioPath)
        {
            using (var file = TagLib.File.Create(audioPath))
            {
                if (file != null)
                {
                    IPicture[] pictures = file.Tag.Pictures;
                    if (pictures.Length > 0)
                    {
                        return pictures[0].Data.Data;
                    }
                }
            }
            // Trả về ảnh trắng
            return CreateBlankImage();
        }

        // Tạo ảnh trắng
        private byte[] CreateBlankImage()
        {
            using (Bitmap blankImage = new Bitmap(200, 200)) // Kích thước của ảnh trắng
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    blankImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
        #endregion

        #region Main button (Play/Pause/Next/Previous)
        public void btnSkipright_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvplay.SelectedRows.Count > 0 && dgvplay.SelectedRows[0].Index < dgvplay.Rows.Count - 1)
                {
                    int nextRowIndex = dgvplay.SelectedRows[0].Index + 1;
                    dgvplay.ClearSelection();
                    dgvplay.Rows[nextRowIndex].Selected = true;
                    dgvplay.Rows[0].Selected = false;
                }
                else
                {
                    dgvplay.Rows[dgvplay.Rows.Count - 1].Selected = false;
                    dgvplay.Rows[0].Selected = true;
                }
            }
            catch
            {
                return;
            }
        }

        public void btnSkipleft_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvplay.SelectedRows.Count > 0 && dgvplay.SelectedRows[0].Index > 0)
                {
                    int previousRowIndex = dgvplay.SelectedRows[0].Index - 1;
                    dgvplay.ClearSelection();
                    dgvplay.Rows[previousRowIndex].Selected = true;
                    dgvplay.Rows[0].Selected = false;
                }
                else
                {
                    dgvplay.Rows[dgvplay.Rows.Count - 1].Selected = true;
                    dgvplay.Rows[0].Selected = false;
                }
            }
            catch
            {
                return;
            }
        }

        // Biến để lưu vị trí phát hiện tại của bài hát
        private double currentPosition = 0;

        public void btnPlay_Click(object sender, EventArgs e)
        {
            btnPause.BringToFront();
            int selectedID;
            string path = "";

            if (dgvplay.SelectedRows.Count > 0)
            {
                selectedID = Convert.ToInt32(dgvplay.SelectedRows[0].Cells["ID"].Value);
            }
            else if (dgvplay.Rows.Count > 0) // Nếu không có dòng nào được chọn, chọn dòng đầu tiên
            {
                selectedID = Convert.ToInt32(dgvplay.Rows[0].Cells["ID"].Value);
                dgvplay.Rows[0].Selected = true; // Chọn dòng đầu tiên
            }
            else // Không có dữ liệu để hiển thị
            {
                return;
            }

            lblSongtitle.Text = dgvplay.SelectedRows[0].Cells["name"].Value.ToString();
            lblSong_name.Text = dgvplay.SelectedRows[0].Cells["name"].Value.ToString();
            lblArtists.Text = dgvplay.SelectedRows[0].Cells["artist_name"].Value.ToString();
            lblArtist.Text = dgvplay.SelectedRows[0].Cells["artist_name"].Value.ToString();
            lblDuration.Text = dgvplay.SelectedRows[0].Cells["duration"].Value.ToString();

            string connectionString = @"Data Source=QHUY\SQLEXPRESS;Initial Catalog=MusicPlayer;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT path FROM SONGS WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", selectedID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        path = result.ToString().Trim();
                        //MessageBox.Show($"Đường dẫn của bài hát là: {path}", "Thông tin", MessageBoxButtons.OK);
                        if (!string.IsNullOrEmpty(path))
                        {
                            if (currentPosition > 0)
                            {
                                player.URL = path;
                                player.controls.currentPosition = currentPosition; // Thiết lập vị trí phát từ currentPosition
                                player.controls.play();
                                lblTimeRemaining.Text = player.controls.currentItem.duration.ToString();
                            }
                            else
                            {
                                player.URL = path;
                                player.controls.play();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Lấy thumbnail của file FLAC
            byte[] thumbnail = GetThumbnail(path);

            // Hiển thị thumbnail trên picturebox
            if (thumbnail != null)
            {
                pbImage.BackgroundImage = Image.FromStream(new MemoryStream(thumbnail));
                pnImage.BackgroundImage = Image.FromStream(new MemoryStream(thumbnail));
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPlay.BringToFront();
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                currentPosition = player.controls.currentPosition; // Lưu vị trí hiện tại của bài hát
                player.controls.pause();
            }
        }
        #endregion

        #region Media
        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (dgvplay.SelectedRows.Count > 0 && player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double newPosition = (player.currentMedia.duration * trackbar.Value) / trackbar.Maximum;
                player.controls.currentPosition = newPosition;
            }
        }

        private void trackbar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (player != null && player.currentMedia != null)
                {
                    double remainingTime = player.currentMedia.duration - player.controls.currentPosition;
                    lblTimeRemaining.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");
                    lblTime.Text = TimeSpan.FromSeconds(player.controls.currentPosition).ToString(@"mm\:ss");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitializeEvents()
        {
            player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);


            // Sự kiện Tick của Timer để cập nhật vị trí của TrackBar
            trackBarTimer.Tick += new EventHandler(trackBarTimer_Tick);
            trackBarTimer.Interval = 1000; // Cập nhật mỗi giây (1000 milliseconds)
        }

        private async void player_PlayStateChange(int newState)
        {
            if ((WMPLib.WMPPlayState)newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (dgvplay.SelectedRows.Count > 0 && dgvplay.SelectedRows[0].Index < dgvplay.Rows.Count - 1)
                {
                    int nextRowIndex = dgvplay.SelectedRows[0].Index + 1;
                    dgvplay.ClearSelection();
                    dgvplay.Rows[nextRowIndex].Selected = true;
                    dgvplay_CellContentClick(this, new DataGridViewCellEventArgs(0, nextRowIndex));
                    btnPause.PerformClick();
                    dgvplay.Rows[0].Selected = false;   
                    //Tạo độ trễ (0.1s)
                    await Task.Delay(100); 
                    btnPlay.PerformClick();
                }
                else
                {
                    player.controls.stop();
                }
            }
            else if ((WMPLib.WMPPlayState)newState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBarTimer.Start();
            }
            else
            {
                trackBarTimer.Stop();
            }
        }


        private void trackBarTimer_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int newPosition = (int)((player.controls.currentPosition / player.currentMedia.duration) * trackbar.Maximum);
                trackbar.Value = newPosition;
            }
            if (player.currentMedia != null)
            {
                double remainingTime = player.currentMedia.duration - player.controls.currentPosition;
                lblTimeRemaining.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");
                lblTime.Text = TimeSpan.FromSeconds(player.controls.currentPosition).ToString(@"mm\:ss");
            }

        }


        #endregion

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            userMenu.Show(btnAvatar, new Point(-70, btnAvatar.Height));
        }

        private void Frm_Music_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
            Application.Exit();
        }
    }

}
