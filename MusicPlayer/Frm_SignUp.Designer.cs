namespace MusicPlayer
{
    partial class Frm_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SignUp));
            this.lblAppname = new System.Windows.Forms.Label();
            this.lblstart_signup = new System.Windows.Forms.Label();
            this.lblHave_account = new System.Windows.Forms.Label();
            this.btnLogin_ifexist_acc = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBỉthday = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbbIdentity = new System.Windows.Forms.ComboBox();
            this.btnhide = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnSignUp = new CustomButton.CustomButton();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAppname
            // 
            this.lblAppname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAppname.AutoSize = true;
            this.lblAppname.Font = new System.Drawing.Font("Rockwell", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppname.Location = new System.Drawing.Point(153, 9);
            this.lblAppname.Name = "lblAppname";
            this.lblAppname.Size = new System.Drawing.Size(178, 27);
            this.lblAppname.TabIndex = 0;
            this.lblAppname.Text = "MUSICPLAYER";
            // 
            // lblstart_signup
            // 
            this.lblstart_signup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblstart_signup.AutoEllipsis = true;
            this.lblstart_signup.Font = new System.Drawing.Font("Rockwell", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart_signup.Location = new System.Drawing.Point(144, 54);
            this.lblstart_signup.Name = "lblstart_signup";
            this.lblstart_signup.Size = new System.Drawing.Size(234, 36);
            this.lblstart_signup.TabIndex = 0;
            this.lblstart_signup.Text = "Sign up for free";
            // 
            // lblHave_account
            // 
            this.lblHave_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHave_account.AutoSize = true;
            this.lblHave_account.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHave_account.Location = new System.Drawing.Point(107, 117);
            this.lblHave_account.Name = "lblHave_account";
            this.lblHave_account.Size = new System.Drawing.Size(205, 20);
            this.lblHave_account.TabIndex = 0;
            this.lblHave_account.Text = "Already have a account? ";
            // 
            // btnLogin_ifexist_acc
            // 
            this.btnLogin_ifexist_acc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin_ifexist_acc.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_ifexist_acc.Location = new System.Drawing.Point(330, 110);
            this.btnLogin_ifexist_acc.Name = "btnLogin_ifexist_acc";
            this.btnLogin_ifexist_acc.Size = new System.Drawing.Size(79, 34);
            this.btnLogin_ifexist_acc.TabIndex = 1;
            this.btnLogin_ifexist_acc.Text = "Log In";
            this.btnLogin_ifexist_acc.UseVisualStyleBackColor = true;
            this.btnLogin_ifexist_acc.Click += new System.EventHandler(this.btnLogin_ifexist_acc_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(100, 232);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(308, 27);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSignUp_txtusername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(98, 202);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 20);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(98, 267);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(98, 337);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email address";
            // 
            // lblBỉthday
            // 
            this.lblBỉthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBỉthday.AutoSize = true;
            this.lblBỉthday.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBỉthday.Location = new System.Drawing.Point(98, 405);
            this.lblBỉthday.Name = "lblBỉthday";
            this.lblBỉthday.Size = new System.Drawing.Size(74, 20);
            this.lblBỉthday.TabIndex = 8;
            this.lblBỉthday.Text = "Bỉthday";
            // 
            // lblIdentity
            // 
            this.lblIdentity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentity.Location = new System.Drawing.Point(98, 475);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(76, 20);
            this.lblIdentity.TabIndex = 8;
            this.lblIdentity.Text = "Identity";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(101, 292);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(308, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSignUp_txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(101, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSignUp_txtEmail_KeyDown);
            // 
            // cbbIdentity
            // 
            this.cbbIdentity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbIdentity.Font = new System.Drawing.Font("Rockwell", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIdentity.FormattingEnabled = true;
            this.cbbIdentity.ItemHeight = 19;
            this.cbbIdentity.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-binary"});
            this.cbbIdentity.Location = new System.Drawing.Point(102, 500);
            this.cbbIdentity.Name = "cbbIdentity";
            this.cbbIdentity.Size = new System.Drawing.Size(307, 27);
            this.cbbIdentity.TabIndex = 6;
            // 
            // btnhide
            // 
            this.btnhide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnhide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhide.BackgroundImage")));
            this.btnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhide.Location = new System.Drawing.Point(378, 292);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(30, 29);
            this.btnhide.TabIndex = 7;
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btnReveal
            // 
            this.btnReveal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReveal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReveal.BackgroundImage")));
            this.btnReveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReveal.Location = new System.Drawing.Point(378, 292);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(30, 29);
            this.btnReveal.TabIndex = 7;
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignUp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Rockwell", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(100, 553);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(308, 68);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // dtBirthday
            // 
            this.dtBirthday.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(102, 428);
            this.dtBirthday.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(306, 26);
            this.dtBirthday.TabIndex = 11;
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 634);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.cbbIdentity);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblBỉthday);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin_ifexist_acc);
            this.Controls.Add(this.lblHave_account);
            this.Controls.Add(this.lblstart_signup);
            this.Controls.Add(this.lblAppname);
            this.Font = new System.Drawing.Font("Rockwell", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Frm_SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppname;
        private System.Windows.Forms.Label lblstart_signup;
        private System.Windows.Forms.Label lblHave_account;
        private System.Windows.Forms.Button btnLogin_ifexist_acc;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBỉthday;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbIdentity;
        private System.Windows.Forms.Button btnhide;
        private CustomButton.CustomButton btnSignUp;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.DateTimePicker dtBirthday;
    }
}