namespace MusicPlayer
{
    partial class Frm_Resetpassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new CustomButton.CustomButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnReset = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnChangepw = new CustomButton.CustomButton();
            this.txtCfrmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.pnReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email to receive a link to reset your password.";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(75, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(424, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reset your password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email address";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(169, 247);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(225, 42);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOTP.Location = new System.Drawing.Point(75, 199);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(319, 26);
            this.txtOTP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verification code";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(400, 199);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 28);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnReset
            // 
            this.pnReset.Controls.Add(this.btnOut);
            this.pnReset.Controls.Add(this.lblNotice);
            this.pnReset.Controls.Add(this.btnChangepw);
            this.pnReset.Controls.Add(this.txtCfrmPass);
            this.pnReset.Controls.Add(this.txtPass);
            this.pnReset.Controls.Add(this.label7);
            this.pnReset.Controls.Add(this.label6);
            this.pnReset.Controls.Add(this.label5);
            this.pnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnReset.Location = new System.Drawing.Point(0, 0);
            this.pnReset.Name = "pnReset";
            this.pnReset.Size = new System.Drawing.Size(583, 301);
            this.pnReset.TabIndex = 5;
            this.pnReset.Visible = false;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(485, 9);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(86, 30);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Exit";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(130, 179);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 19);
            this.lblNotice.TabIndex = 4;
            // 
            // btnChangepw
            // 
            this.btnChangepw.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangepw.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangepw.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangepw.BorderRadius = 20;
            this.btnChangepw.BorderSize = 0;
            this.btnChangepw.FlatAppearance.BorderSize = 0;
            this.btnChangepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangepw.ForeColor = System.Drawing.Color.White;
            this.btnChangepw.Location = new System.Drawing.Point(169, 211);
            this.btnChangepw.Name = "btnChangepw";
            this.btnChangepw.Size = new System.Drawing.Size(211, 45);
            this.btnChangepw.TabIndex = 2;
            this.btnChangepw.Text = "Change password";
            this.btnChangepw.TextColor = System.Drawing.Color.White;
            this.btnChangepw.UseVisualStyleBackColor = false;
            this.btnChangepw.Click += new System.EventHandler(this.btnChangepw_Click);
            // 
            // txtCfrmPass
            // 
            this.txtCfrmPass.Location = new System.Drawing.Point(134, 150);
            this.txtCfrmPass.Name = "txtCfrmPass";
            this.txtCfrmPass.Size = new System.Drawing.Size(286, 26);
            this.txtCfrmPass.TabIndex = 1;
            this.txtCfrmPass.TextChanged += new System.EventHandler(this.txtCfrmPass_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(134, 90);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(286, 26);
            this.txtPass.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirm password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reset your password";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // Frm_Resetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 301);
            this.Controls.Add(this.pnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Resetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.pnReset.ResumeLayout(false);
            this.pnReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomButton.CustomButton btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnReset;
        private System.Windows.Forms.Label lblNotice;
        private CustomButton.CustomButton btnChangepw;
        private System.Windows.Forms.TextBox txtCfrmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOut;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}