using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MusicPlayer
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblAppname.Paint += new PaintEventHandler(lblAppname_Paint); //Tạo khung label
            lblAppname.Location = new Point((this.ClientSize.Width - lblAppname.Size.Width) / 2, (lblAppname.Size.Height) / 2);
            lblstart_login.Location = new Point((this.ClientSize.Width - lblstart_login.Size.Width) / 2, (lblstart_login.Size.Height) * 2);
        }
        private void lblAppname_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, lblAppname.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnReveal_Click(object sender, EventArgs e) //Hiển thị password bị ẩn
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        private void btnhide_Click(object sender, EventArgs e) //Ẩn password
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnReveal.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_SignUp frm_SignUp = new Frm_SignUp();
            frm_SignUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                string query = $"SELECT username, password FROM USERS WHERE username = '{txtUsername.Text}'";
                DataTable dt = DataHelper.GetDataTable(query);

                if (dt.Rows.Count > 0)
                {
                    string passwordFromDB = dt.Rows[0]["password"].ToString();
                    if (passwordFromDB == password)
                    {
                        // Create the correct path to the file
                        string filePath = @"temp.txt";

                        // Write username to file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(username);
                            writer.Close();
                        }
                        Frm_Music frmmusic = new Frm_Music();
                        frmmusic.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Frm_Resetpassword frmreset = new Frm_Resetpassword();
            frmreset.ShowDialog();
        }
    }
}
