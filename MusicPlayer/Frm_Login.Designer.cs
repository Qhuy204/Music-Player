namespace MusicPlayer
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.lblstart_login = new System.Windows.Forms.Label();
            this.lblAppname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblnot_have_cc = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.btnForgotPassword = new CustomButton.CustomButton();
            this.btnLogin = new CustomButton.CustomButton();
            this.SuspendLayout();
            // 
            // lblstart_login
            // 
            this.lblstart_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblstart_login.AutoEllipsis = true;
            this.lblstart_login.Font = new System.Drawing.Font("Rockwell", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart_login.Location = new System.Drawing.Point(192, 49);
            this.lblstart_login.Name = "lblstart_login";
            this.lblstart_login.Size = new System.Drawing.Size(109, 33);
            this.lblstart_login.TabIndex = 1;
            this.lblstart_login.Text = "Log In";
            // 
            // lblAppname
            // 
            this.lblAppname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAppname.AutoSize = true;
            this.lblAppname.Font = new System.Drawing.Font("Rockwell", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppname.Location = new System.Drawing.Point(158, 8);
            this.lblAppname.Name = "lblAppname";
            this.lblAppname.Size = new System.Drawing.Size(178, 27);
            this.lblAppname.TabIndex = 2;
            this.lblAppname.Text = "MUSICPLAYER";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(104, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(104, 215);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(108, 176);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(303, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(108, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(303, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // lblnot_have_cc
            // 
            this.lblnot_have_cc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnot_have_cc.AutoSize = true;
            this.lblnot_have_cc.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnot_have_cc.Location = new System.Drawing.Point(108, 111);
            this.lblnot_have_cc.Name = "lblnot_have_cc";
            this.lblnot_have_cc.Size = new System.Drawing.Size(190, 20);
            this.lblnot_have_cc.TabIndex = 5;
            this.lblnot_have_cc.Text = "Not have an account?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignUp.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(323, 106);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 30);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnReveal
            // 
            this.btnReveal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReveal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReveal.BackgroundImage")));
            this.btnReveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReveal.Location = new System.Drawing.Point(381, 239);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(30, 29);
            this.btnReveal.TabIndex = 3;
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // btnhide
            // 
            this.btnhide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnhide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhide.BackgroundImage")));
            this.btnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhide.Location = new System.Drawing.Point(381, 238);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(30, 29);
            this.btnhide.TabIndex = 9;
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnForgotPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgotPassword.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgotPassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnForgotPassword.BorderRadius = 20;
            this.btnForgotPassword.BorderSize = 0;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.White;
            this.btnForgotPassword.Location = new System.Drawing.Point(108, 379);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(303, 38);
            this.btnForgotPassword.TabIndex = 12;
            this.btnForgotPassword.Text = "Forgot your password?";
            this.btnForgotPassword.TextColor = System.Drawing.Color.White;
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Rockwell", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(108, 299);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(303, 63);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log In";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(526, 436);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblnot_have_cc);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblstart_login);
            this.Controls.Add(this.lblAppname);
            this.Font = new System.Drawing.Font("Rockwell", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstart_login;
        private System.Windows.Forms.Label lblAppname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblnot_have_cc;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnhide;
        private CustomButton.CustomButton btnLogin;
        private CustomButton.CustomButton btnForgotPassword;
    }
}