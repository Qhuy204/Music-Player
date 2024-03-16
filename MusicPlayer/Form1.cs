using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAppname.Paint += new PaintEventHandler(lblAppname_Paint); //Tạo khung label
            lblAppname.Location = new Point((this.ClientSize.Width - lblAppname.Size.Width) / 2, (lblAppname.Size.Height) / 2);

        }
        private void lblAppname_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, lblAppname.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Frm_SignUp frm_SignUp = new Frm_SignUp();
            frm_SignUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
            this.Hide();
        }
    }
}
