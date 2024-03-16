using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnChangeemail_Click(object sender, EventArgs e)
        {
            Frm_ResetEmail rs = new Frm_ResetEmail();
            rs.StartPosition = FormStartPosition.CenterParent; 
            rs.Owner = this; 
            rs.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Frm_Resetpassword rs = new Frm_Resetpassword();
            rs.StartPosition = FormStartPosition.CenterParent;
            rs.Owner = this;
            rs.ShowDialog();
        }
        public string user;
        private void Account_Load(object sender, EventArgs e)
        {
            string source = @"temp.txt";
            StreamReader sr = new StreamReader(source);
            user = sr.ReadLine();
            string query = $"SELECT * FROM USERS WHERE username = '{user}'";
            DataTable dt = DataHelper.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                string path = dt.Rows[0]["profile_picture"].ToString().Trim();
                //MessageBox.Show(path);
                btnAvatar.BackgroundImage = Image.FromFile(path);
                btnAvatar.BackgroundImageLayout = ImageLayout.Stretch;
                string email = dt.Rows[0]["email"].ToString().Trim();
                txtEmail.Texts = email;
                string pass = dt.Rows[0]["password"].ToString().Trim();
                txtPassword.Texts = pass;
                string name = dt.Rows[0]["name"].ToString();
                txtUsername.Texts = name;
                lblName.Text = txtUsername.Texts;
                string gender = dt.Rows[0]["gender"].ToString().Trim();
                if (gender == "Male")
                {
                    rbMale.Checked = true; 
                }
                else if (gender == "Female")
                {
                    rbFemale.Checked = true; 
                }
                else
                {
                    rbNonbinary.Checked = true;
                }
                string birthday = dt.Rows[0]["birthday"].ToString().Trim();
                dtBirthday.Text = birthday;

            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = null;
                if (rbMale.Checked = true)
                {
                    gender = "Male";
                }
                else if (rbFemale.Checked = true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Non - Binary";
                }
                string name = txtUsername.Texts;
                DateTime birthday = DateTime.Parse(dtBirthday.Value.ToString().Trim());
                string query = $"UPDATE USERS SET name = N'{name}', gender = '{gender}', birthday = '{birthday}' WHERE username = '{user}'";
                DataHelper.ThucThiSQL(query);
                MessageBox.Show("Your data has been updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Multiselect = false;
                open.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff;*.ico;*.svg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = open.FileName.Replace("\"", "");

                    // Validate file extension to ensure it's an image
                    string[] validImageExtensions = { ".bmp", ".jpg", ".jpeg", ".gif", ".png", ".tif", ".tiff", ".ico", ".svg" };
                    string extension = Path.GetExtension(selectedImagePath);
                    if (!validImageExtensions.Contains(extension.ToLower()))
                    {
                        MessageBox.Show("Error: Invalid image file format.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update database with image path using parameterized query
                    string query = "UPDATE USERS SET profile_picture = @ImagePath WHERE username = @Username";
                    string conn = @"Data Source=QHUY\SQLEXPRESS;Initial Catalog=MusicPlayer;Integrated Security=True";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath);
                                cmd.Parameters.AddWithValue("@Username", user);
                                connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Set background image for btnAvatar
                    try
                    {
                        btnAvatar.BackgroundImage = Image.FromFile(selectedImagePath);
                        btnAvatar.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

    }
}
