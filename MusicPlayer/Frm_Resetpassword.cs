using System;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;


namespace MusicPlayer
{
    public partial class Frm_Resetpassword : Form
    {
        public Frm_Resetpassword()
        {
            InitializeComponent();
        }
        public int code = 0;
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Get email and code from textboxes
            string email = txtEmail.Text.ToLower().Trim();
            //Check the email existed or not
            string query = $"SELECT COUNT(*) AS Count FROM USERS WHERE email = '{email}'";
            DataTable dt = DataHelper.GetDataTable(query);
            int count = int.Parse(dt.Rows[0]["Count"].ToString());
            if (count == 1)
            {
                // Send email
                code = SendEmail.SendMail("This is your Password reset verification code", email);
            }
            else
            {
                // Email address not found , display error message
                MessageBox.Show("This email address is not associated with any account!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Clear();
                txtEmail.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int? input = null;
            if (!string.IsNullOrEmpty(txtOTP.Text))
            {
                input = int.Parse(txtOTP.Text.Trim());
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in your email address!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (input.HasValue)
            {
                try
                {
                    if (input == code)
                    {
                        pnReset.Visible = true;
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

        private void txtCfrmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtCfrmPass.Text != txtPass.Text)
            {
                lblNotice.Text = "Password confirmation doesn't match the password";
            }
            else
            {
                lblNotice.Text = "";
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangepw_Click(object sender, EventArgs e)
        {
            if (lblNotice.Text == "")
            {
                string query = $"UPDATE USERS SET password = '{txtPass.Text}' WHERE email = '{txtEmail.Text.Trim().ToLower()}'";
                DataHelper.ThucThiSQL(query);
                MessageBox.Show("Password changed successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password confirmation doesn't match the password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCfrmPass.Focus();
            }
            
        }
    }
}
