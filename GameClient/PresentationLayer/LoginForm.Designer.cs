
using System;
using System.Runtime.InteropServices;

namespace PresentationLayer
{
    partial class LoginForm
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
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
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonErrorLastname = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.LabelMinimize = new System.Windows.Forms.Label();
            this.buttonErrorName = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonLinkToRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(185, 234);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(149, 27);
            this.checkBoxShowPassword.TabIndex = 47;
            this.checkBoxShowPassword.TabStop = false;
            this.checkBoxShowPassword.Text = "Show password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game client login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPassword.Location = new System.Drawing.Point(194, 184);
            this.textBoxPassword.MaxLength = 30;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(391, 25);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorLastname
            // 
            this.buttonErrorLastname.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorLastname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorLastname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorLastname.Location = new System.Drawing.Point(185, 182);
            this.buttonErrorLastname.Name = "buttonErrorLastname";
            this.buttonErrorLastname.Size = new System.Drawing.Size(411, 30);
            this.buttonErrorLastname.TabIndex = 30;
            this.buttonErrorLastname.TabStop = false;
            this.buttonErrorLastname.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(396, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 40);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Enabled = false;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(185, 283);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(200, 40);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(46, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 3);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email Address";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxEmail.Location = new System.Drawing.Point(194, 119);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(391, 25);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.MouseEnter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.PanelHeader.Controls.Add(this.LabelClose);
            this.PanelHeader.Controls.Add(this.LabelMinimize);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Location = new System.Drawing.Point(4, 3);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(668, 70);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClose.Location = new System.Drawing.Point(622, 3);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(37, 38);
            this.LabelClose.TabIndex = 2;
            this.LabelClose.Text = "×";
            this.LabelClose.Click += new System.EventHandler(this.LabelClose_Click);
            this.LabelClose.MouseEnter += new System.EventHandler(this.LabelClose_MouseHover);
            this.LabelClose.MouseLeave += new System.EventHandler(this.LabelClose_MouseLeave);
            // 
            // LabelMinimize
            // 
            this.LabelMinimize.AutoSize = true;
            this.LabelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinimize.Location = new System.Drawing.Point(591, -6);
            this.LabelMinimize.Name = "LabelMinimize";
            this.LabelMinimize.Size = new System.Drawing.Size(30, 41);
            this.LabelMinimize.TabIndex = 1;
            this.LabelMinimize.Text = "_";
            this.LabelMinimize.Click += new System.EventHandler(this.LabelMinimize_Click);
            this.LabelMinimize.MouseEnter += new System.EventHandler(this.LabelMinimize_MouseHover);
            this.LabelMinimize.MouseLeave += new System.EventHandler(this.LabelMinimize_MouseLeave);
            // 
            // buttonErrorName
            // 
            this.buttonErrorName.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorName.Location = new System.Drawing.Point(185, 117);
            this.buttonErrorName.Name = "buttonErrorName";
            this.buttonErrorName.Size = new System.Drawing.Size(411, 30);
            this.buttonErrorName.TabIndex = 26;
            this.buttonErrorName.TabStop = false;
            this.buttonErrorName.UseVisualStyleBackColor = false;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(678, 484);
            this.PanelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonLinkToRegister);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxShowPassword);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.buttonErrorLastname);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.PanelHeader);
            this.panel1.Controls.Add(this.buttonErrorName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 478);
            this.panel1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(182, 76);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(254, 25);
            this.labelError.TabIndex = 50;
            this.labelError.Text = "Incorrect email or password.";
            this.labelError.Visible = false;
            // 
            // buttonLinkToRegister
            // 
            this.buttonLinkToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonLinkToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLinkToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinkToRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkToRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLinkToRegister.Location = new System.Drawing.Point(267, 396);
            this.buttonLinkToRegister.Name = "buttonLinkToRegister";
            this.buttonLinkToRegister.Size = new System.Drawing.Size(329, 40);
            this.buttonLinkToRegister.TabIndex = 49;
            this.buttonLinkToRegister.Text = "CREATE A NEW ACCOUNT...";
            this.buttonLinkToRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLinkToRegister.UseVisualStyleBackColor = false;
            this.buttonLinkToRegister.Click += new System.EventHandler(this.buttonLinkToRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "Don\'t have a account?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 484);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonErrorLastname;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label LabelMinimize;
        private System.Windows.Forms.Button buttonErrorName;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLinkToRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
    }
}