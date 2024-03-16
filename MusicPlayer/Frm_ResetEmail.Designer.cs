namespace MusicPlayer
{
    partial class Frm_ResetEmail
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
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnconfirm = new CustomButton.CustomButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnChange = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnChangeEmail = new CustomButton.CustomButton();
            this.txtCfrmEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm your Identity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "For security reasons, we\'ll send a verifycation code to: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnconfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnconfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnconfirm.BorderRadius = 20;
            this.btnconfirm.BorderSize = 0;
            this.btnconfirm.FlatAppearance.BorderSize = 0;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnconfirm.ForeColor = System.Drawing.Color.White;
            this.btnconfirm.Location = new System.Drawing.Point(161, 199);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(160, 52);
            this.btnconfirm.TabIndex = 2;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.TextColor = System.Drawing.Color.White;
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 111);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 29);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCode.Location = new System.Drawing.Point(135, 168);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 26);
            this.txtCode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Verification code: ";
            // 
            // pnChange
            // 
            this.pnChange.Controls.Add(this.label4);
            this.pnChange.Controls.Add(this.lblNotice);
            this.pnChange.Controls.Add(this.btnChangeEmail);
            this.pnChange.Controls.Add(this.txtCfrmEmail);
            this.pnChange.Controls.Add(this.txtEmail);
            this.pnChange.Controls.Add(this.label7);
            this.pnChange.Controls.Add(this.label6);
            this.pnChange.Controls.Add(this.label2);
            this.pnChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChange.Location = new System.Drawing.Point(0, 0);
            this.pnChange.Name = "pnChange";
            this.pnChange.Size = new System.Drawing.Size(491, 263);
            this.pnChange.TabIndex = 9;
            this.pnChange.Visible = false;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNotice.Location = new System.Drawing.Point(101, 168);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 17);
            this.lblNotice.TabIndex = 11;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangeEmail.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangeEmail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeEmail.BorderRadius = 20;
            this.btnChangeEmail.BorderSize = 0;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.ForeColor = System.Drawing.Color.White;
            this.btnChangeEmail.Location = new System.Drawing.Point(143, 206);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(211, 45);
            this.btnChangeEmail.TabIndex = 10;
            this.btnChangeEmail.Text = "Change Email";
            this.btnChangeEmail.TextColor = System.Drawing.Color.White;
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // txtCfrmEmail
            // 
            this.txtCfrmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCfrmEmail.Location = new System.Drawing.Point(105, 139);
            this.txtCfrmEmail.Name = "txtCfrmEmail";
            this.txtCfrmEmail.Size = new System.Drawing.Size(286, 23);
            this.txtCfrmEmail.TabIndex = 7;
            this.txtCfrmEmail.TextChanged += new System.EventHandler(this.txtCfrmEmail_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(105, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(101, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Confirm Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(101, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "New Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change your Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // Frm_ResetEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 263);
            this.Controls.Add(this.pnChange);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ResetEmail";
            this.Text = "Frm_ResetEmail";
            this.Load += new System.EventHandler(this.Frm_ResetEmail_Load);
            this.pnChange.ResumeLayout(false);
            this.pnChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomButton.CustomButton btnconfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnChange;
        private System.Windows.Forms.Label lblNotice;
        private CustomButton.CustomButton btnChangeEmail;
        private System.Windows.Forms.TextBox txtCfrmEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}