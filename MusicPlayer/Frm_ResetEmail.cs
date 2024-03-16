using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Frm_ResetEmail : Form
    {
        public Frm_ResetEmail()
        {
            InitializeComponent();
        }
        public int code = 0;
        private void Frm_ResetEmail_Load(object sender, EventArgs e)
        {
            string source = @"temp.txt";
            StreamReader sr = new StreamReader(source);
            string user = sr.ReadLine();
            sr.Close();
            string query = $"SELECT * FROM USERS WHERE username = '{user}'";
            DataTable dt = DataHelper.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                string email = dt.Rows[0]["email"].ToString();
                lblEmail.Text = email;
            }
            else
            {
                lblEmail.Text = "Email not found!";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            code = SendEmail.SendMail("This is the verification code for your email change action: ", lblEmail.Text);
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            int? input = null;
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                input = int.Parse(txtCode.Text.Trim());
            }
            if (input.HasValue)
            {
                try
                {
                    if (input == code)
                    {
                        pnChange.Visible = true;
                        btnExit.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Wrong verification code!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter the verification code!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (lblNotice.Text == "")
            {
                string query = $"UPDATE USERS SET email = '{txtCfrmEmail.Text}' WHERE email = '{lblEmail.Text.Trim().ToLower()}'";
                DataHelper.ThucThiSQL(query);
                MessageBox.Show("Email changed successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Frm_ResetEmail_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Email confirmation doesn't match the Email!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCfrmEmail.Focus();
            }
        }

        private void txtCfrmEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtCfrmEmail.Text != txtEmail.Text)
            {
                lblNotice.Text = "Email confirmation doesn't match the Email!";
            }
            else
            {
                lblNotice.Text = "";
            }
        }
    }
}
