using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicPlayer
{
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {
            lblAppname.Paint += new PaintEventHandler(lblAppname_Paint); //Tạo khung label
            lblAppname.Location = new Point((this.ClientSize.Width - lblAppname.Size.Width) / 2, (lblAppname.Size.Height) / 2);
            lblstart_signup.Location = new Point((this.ClientSize.Width - lblstart_signup.Size.Width) / 2, (lblstart_signup.Size.Height) * 2);
            this.KeyPreview = true;
            txtUsername.Focus();
        }
        private void lblAppname_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, lblAppname.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }


        private void btnReveal_Click(object sender, EventArgs e) //Hiển thị password bị ẩn
        {
            if(txtPassword.PasswordChar == '*')
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


        private void FrmSignUp_txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
        private void FrmSignUp_txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }
        private void FrmSignUp_txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtBirthday.Focus();
            }
        }
        private void FrmSignUp_txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbIdentity.Focus();
            }
        }

        void ClearText()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            cbbIdentity.SelectedIndex = -1;
            dtBirthday.ResetText();
            txtUsername.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string name = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim().ToLower();
            DateTime birthday = DateTime.Parse(dtBirthday.Value.ToString().Trim());
            string gender = cbbIdentity.Text.Trim();
            string profile_picture = @"user.png";
            try
            {
                string query = "SELECT MAX(ID) AS MaxID FROM USERS";
                DataTable dt = DataHelper.GetDataTable(query);
                int lastID = int.Parse(dt.Rows[0]["MaxID"].ToString());
                int ID = lastID + 1;
                query = $"SELECT COUNT(*) AS Count FROM USERS WHERE username = '{txtUsername.Text.Trim()}'";
                dt = DataHelper.GetDataTable(query);
                int count = int.Parse(dt.Rows[0]["Count"].ToString());

                if (count == 0)
                {
                    query = $"SELECT COUNT(*) AS Count1 FROM USERS WHERE email = '{email}'";  
                    DataTable dtb = DataHelper.GetDataTable(query);
                    int count1 = int.Parse(dtb.Rows[0]["Count1"].ToString());  
                    if (count1 == 0)
                    {
                        query = $"INSERT INTO USERS (ID, username, password, name, email, birthday, gender, profile_picture) VALUES ({ID}, '{username}', '{password}', '{name}', '{email}', '{birthday}', '{gender}', N'{profile_picture}')";
                        DataHelper.ThucThiSQL(query);

                        // Display success message
                        MessageBox.Show("Registered successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                        Frm_Login frmlogin = new Frm_Login();
                        frmlogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Email already exists, display error message
                        MessageBox.Show("The email address alredy existed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Clear();
                        txtEmail.Focus();
                    }
                }
                else
                {
                    // Username already exists, display error message
                    MessageBox.Show("The username alredy existed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
            }
            catch (SqlException ex)
            {
                // Handle database error
                MessageBox.Show("Error: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLogin_ifexist_acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frmLogIn = new Frm_Login();
            frmLogIn.Show();
        }
    }
}
