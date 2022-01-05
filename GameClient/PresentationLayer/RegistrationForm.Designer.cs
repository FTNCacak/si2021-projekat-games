
using System;
using System.Runtime.InteropServices;

namespace PresentationLayer
{
    partial class RegistrationForm
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelErrorFormat = new System.Windows.Forms.Label();
            this.labelFormatLastaname = new System.Windows.Forms.Label();
            this.labelFormatName = new System.Windows.Forms.Label();
            this.labelFormatPhone = new System.Windows.Forms.Label();
            this.labelFormatEmail = new System.Windows.Forms.Label();
            this.labelFormatConfirmPassword = new System.Windows.Forms.Label();
            this.labelFormatPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonErrorConfirmPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonErrorPassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonErrorPhone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonErrorEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.buttonErrorLastname = new System.Windows.Forms.Button();
            this.labelErrorEmpty = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.LabelMinimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonErrorName = new System.Windows.Forms.Button();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.labelQuestionMark = new System.Windows.Forms.Label();
            this.labelEmailExists = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(663, 604);
            this.PanelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.labelErrorFormat);
            this.panel1.Controls.Add(this.labelFormatLastaname);
            this.panel1.Controls.Add(this.labelFormatName);
            this.panel1.Controls.Add(this.labelFormatPhone);
            this.panel1.Controls.Add(this.labelFormatEmail);
            this.panel1.Controls.Add(this.labelFormatConfirmPassword);
            this.panel1.Controls.Add(this.labelFormatPassword);
            this.panel1.Controls.Add(this.checkBoxShowPassword);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxConfirmPassword);
            this.panel1.Controls.Add(this.buttonErrorConfirmPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.buttonErrorPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.buttonErrorPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.buttonErrorEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.buttonErrorLastname);
            this.panel1.Controls.Add(this.labelErrorEmpty);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Controls.Add(this.PanelHeader);
            this.panel1.Controls.Add(this.buttonErrorName);
            this.panel1.Controls.Add(this.linkLabelLogin);
            this.panel1.Controls.Add(this.labelQuestionMark);
            this.panel1.Controls.Add(this.labelEmailExists);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 598);
            this.panel1.TabIndex = 0;
            // 
            // labelErrorFormat
            // 
            this.labelErrorFormat.AutoSize = true;
            this.labelErrorFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorFormat.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFormat.Location = new System.Drawing.Point(86, 133);
            this.labelErrorFormat.Name = "labelErrorFormat";
            this.labelErrorFormat.Size = new System.Drawing.Size(262, 28);
            this.labelErrorFormat.TabIndex = 54;
            this.labelErrorFormat.Text = "Field is not in correct format.";
            this.labelErrorFormat.Visible = false;
            // 
            // labelFormatLastaname
            // 
            this.labelFormatLastaname.AutoSize = true;
            this.labelFormatLastaname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatLastaname.ForeColor = System.Drawing.Color.Red;
            this.labelFormatLastaname.Location = new System.Drawing.Point(332, 240);
            this.labelFormatLastaname.Name = "labelFormatLastaname";
            this.labelFormatLastaname.Size = new System.Drawing.Size(261, 23);
            this.labelFormatLastaname.TabIndex = 53;
            this.labelFormatLastaname.Text = "Example of valid lastname: Smith";
            this.labelFormatLastaname.Visible = false;
            // 
            // labelFormatName
            // 
            this.labelFormatName.AutoSize = true;
            this.labelFormatName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatName.ForeColor = System.Drawing.Color.Red;
            this.labelFormatName.Location = new System.Drawing.Point(88, 240);
            this.labelFormatName.Name = "labelFormatName";
            this.labelFormatName.Size = new System.Drawing.Size(227, 23);
            this.labelFormatName.TabIndex = 52;
            this.labelFormatName.Text = "Example of valid name: John";
            this.labelFormatName.Visible = false;
            // 
            // labelFormatPhone
            // 
            this.labelFormatPhone.AutoSize = true;
            this.labelFormatPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatPhone.ForeColor = System.Drawing.Color.Red;
            this.labelFormatPhone.Location = new System.Drawing.Point(331, 337);
            this.labelFormatPhone.Name = "labelFormatPhone";
            this.labelFormatPhone.Size = new System.Drawing.Size(301, 23);
            this.labelFormatPhone.TabIndex = 51;
            this.labelFormatPhone.Text = "Example of valid phone: 060/708-0090";
            this.labelFormatPhone.Visible = false;
            // 
            // labelFormatEmail
            // 
            this.labelFormatEmail.AutoSize = true;
            this.labelFormatEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatEmail.ForeColor = System.Drawing.Color.Red;
            this.labelFormatEmail.Location = new System.Drawing.Point(90, 337);
            this.labelFormatEmail.Name = "labelFormatEmail";
            this.labelFormatEmail.Size = new System.Drawing.Size(298, 23);
            this.labelFormatEmail.TabIndex = 50;
            this.labelFormatEmail.Text = "Email address is not in correct format.";
            this.labelFormatEmail.Visible = false;
            // 
            // labelFormatConfirmPassword
            // 
            this.labelFormatConfirmPassword.AutoSize = true;
            this.labelFormatConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.labelFormatConfirmPassword.Location = new System.Drawing.Point(334, 430);
            this.labelFormatConfirmPassword.Name = "labelFormatConfirmPassword";
            this.labelFormatConfirmPassword.Size = new System.Drawing.Size(255, 23);
            this.labelFormatConfirmPassword.TabIndex = 49;
            this.labelFormatConfirmPassword.Text = "This must match your password.";
            this.labelFormatConfirmPassword.Visible = false;
            // 
            // labelFormatPassword
            // 
            this.labelFormatPassword.AutoSize = true;
            this.labelFormatPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatPassword.ForeColor = System.Drawing.Color.Red;
            this.labelFormatPassword.Location = new System.Drawing.Point(89, 430);
            this.labelFormatPassword.Name = "labelFormatPassword";
            this.labelFormatPassword.Size = new System.Drawing.Size(253, 23);
            this.labelFormatPassword.TabIndex = 48;
            this.labelFormatPassword.Text = "Minumum password length is 8.";
            this.labelFormatPassword.Visible = false;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(91, 464);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(193, 27);
            this.checkBoxShowPassword.TabIndex = 47;
            this.checkBoxShowPassword.TabStop = false;
            this.checkBoxShowPassword.Text = "Show password fields";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(534, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 37);
            this.label12.TabIndex = 45;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 28);
            this.label13.TabIndex = 44;
            this.label13.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(344, 397);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(194, 25);
            this.textBoxConfirmPassword.TabIndex = 6;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            this.textBoxConfirmPassword.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorConfirmPassword
            // 
            this.buttonErrorConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorConfirmPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorConfirmPassword.Location = new System.Drawing.Point(335, 393);
            this.buttonErrorConfirmPassword.Name = "buttonErrorConfirmPassword";
            this.buttonErrorConfirmPassword.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorConfirmPassword.TabIndex = 46;
            this.buttonErrorConfirmPassword.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPassword.Location = new System.Drawing.Point(99, 396);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(194, 25);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorPassword
            // 
            this.buttonErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorPassword.Location = new System.Drawing.Point(90, 392);
            this.buttonErrorPassword.Name = "buttonErrorPassword";
            this.buttonErrorPassword.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorPassword.TabIndex = 42;
            this.buttonErrorPassword.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(533, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 37);
            this.label10.TabIndex = 37;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(330, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 28);
            this.label11.TabIndex = 36;
            this.label11.Text = "Phone number";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPhone.Location = new System.Drawing.Point(343, 300);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(194, 25);
            this.textBoxPhone.TabIndex = 4;
            this.textBoxPhone.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorPhone
            // 
            this.buttonErrorPhone.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPhone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorPhone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorPhone.Location = new System.Drawing.Point(334, 296);
            this.buttonErrorPhone.Name = "buttonErrorPhone";
            this.buttonErrorPhone.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorPhone.TabIndex = 38;
            this.buttonErrorPhone.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email Address";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxEmail.Location = new System.Drawing.Point(99, 300);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(194, 25);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorEmail
            // 
            this.buttonErrorEmail.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorEmail.Location = new System.Drawing.Point(90, 296);
            this.buttonErrorEmail.Name = "buttonErrorEmail";
            this.buttonErrorEmail.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorEmail.TabIndex = 34;
            this.buttonErrorEmail.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Lastname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxLastname.Location = new System.Drawing.Point(344, 205);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(194, 25);
            this.textBoxLastname.TabIndex = 2;
            this.textBoxLastname.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorLastname
            // 
            this.buttonErrorLastname.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorLastname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorLastname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorLastname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorLastname.Location = new System.Drawing.Point(335, 201);
            this.buttonErrorLastname.Name = "buttonErrorLastname";
            this.buttonErrorLastname.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorLastname.TabIndex = 30;
            this.buttonErrorLastname.TabStop = false;
            this.buttonErrorLastname.UseVisualStyleBackColor = false;
            // 
            // labelErrorEmpty
            // 
            this.labelErrorEmpty.AutoSize = true;
            this.labelErrorEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorEmpty.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmpty.Location = new System.Drawing.Point(86, 133);
            this.labelErrorEmpty.Name = "labelErrorEmpty";
            this.labelErrorEmpty.Size = new System.Drawing.Size(213, 28);
            this.labelErrorEmpty.TabIndex = 24;
            this.labelErrorEmpty.Text = "All fields must be filled.";
            this.labelErrorEmpty.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(335, 515);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(214, 40);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(89, 515);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(216, 40);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(346, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 28);
            this.label14.TabIndex = 21;
            this.label14.Text = "* This field is required.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(93, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 3);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxName.Location = new System.Drawing.Point(100, 204);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 25);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(87, 76);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(348, 41);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "CREATE YOUR ACCOUNT";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.PanelHeader.Controls.Add(this.LabelClose);
            this.PanelHeader.Controls.Add(this.LabelMinimize);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Location = new System.Drawing.Point(4, 3);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(653, 70);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClose.Location = new System.Drawing.Point(618, 3);
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
            this.LabelMinimize.Location = new System.Drawing.Point(587, -6);
            this.LabelMinimize.Name = "LabelMinimize";
            this.LabelMinimize.Size = new System.Drawing.Size(30, 41);
            this.LabelMinimize.TabIndex = 1;
            this.LabelMinimize.Text = "_";
            this.LabelMinimize.Click += new System.EventHandler(this.LabelMinimize_Click);
            this.LabelMinimize.MouseEnter += new System.EventHandler(this.LabelMinimize_MouseHover);
            this.LabelMinimize.MouseLeave += new System.EventHandler(this.LabelMinimize_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game client registration";
            // 
            // buttonErrorName
            // 
            this.buttonErrorName.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorName.Location = new System.Drawing.Point(91, 200);
            this.buttonErrorName.Name = "buttonErrorName";
            this.buttonErrorName.Size = new System.Drawing.Size(214, 30);
            this.buttonErrorName.TabIndex = 26;
            this.buttonErrorName.TabStop = false;
            this.buttonErrorName.UseVisualStyleBackColor = false;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogin.Location = new System.Drawing.Point(364, 133);
            this.linkLabelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(64, 28);
            this.linkLabelLogin.TabIndex = 56;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.Visible = false;
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // labelQuestionMark
            // 
            this.labelQuestionMark.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionMark.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelQuestionMark.Location = new System.Drawing.Point(412, 133);
            this.labelQuestionMark.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuestionMark.Name = "labelQuestionMark";
            this.labelQuestionMark.Size = new System.Drawing.Size(17, 28);
            this.labelQuestionMark.TabIndex = 57;
            this.labelQuestionMark.Text = "?";
            // 
            // labelEmailExists
            // 
            this.labelEmailExists.AutoSize = true;
            this.labelEmailExists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailExists.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelEmailExists.Location = new System.Drawing.Point(89, 133);
            this.labelEmailExists.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmailExists.Name = "labelEmailExists";
            this.labelEmailExists.Size = new System.Drawing.Size(354, 28);
            this.labelEmailExists.TabIndex = 55;
            this.labelEmailExists.Text = "Account already exists. Do you want to ";
            this.labelEmailExists.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(663, 604);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.PanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonErrorPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonErrorPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonErrorEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Button buttonErrorLastname;
        private System.Windows.Forms.Label labelErrorEmpty;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label LabelMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonErrorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonErrorConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelFormatLastaname;
        private System.Windows.Forms.Label labelFormatName;
        private System.Windows.Forms.Label labelFormatPhone;
        private System.Windows.Forms.Label labelFormatEmail;
        private System.Windows.Forms.Label labelFormatConfirmPassword;
        private System.Windows.Forms.Label labelFormatPassword;
        private System.Windows.Forms.Label labelErrorFormat;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Label labelEmailExists;
        private System.Windows.Forms.Label labelQuestionMark;
    }
}

