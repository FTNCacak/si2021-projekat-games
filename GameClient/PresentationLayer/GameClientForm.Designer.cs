
using System;
using System.Runtime.InteropServices;

namespace PresentationLayer
{
    partial class GameClientForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddFunds = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelLibrary = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.LabelMinimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddFunds = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSubmitAddFunds = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelPasswordFormatError = new System.Windows.Forms.Label();
            this.labelPasswordsDontMatchError = new System.Windows.Forms.Label();
            this.labelOldPasswordError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.buttonErrorName = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonProfileSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelProfilePhone = new System.Windows.Forms.Label();
            this.labelProfileEmail = new System.Windows.Forms.Label();
            this.labelProfileLastName = new System.Windows.Forms.Label();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStore = new System.Windows.Forms.Panel();
            this.flowLayoutPanelStore = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxStoreSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.flowLayoutPanelLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearchLibrary = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelNoGamesInLibrary = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.panelAddFunds.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelStore.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.flowLayoutPanelLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1478, 821);
            this.PanelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelHeader);
            this.panel1.Controls.Add(this.panelLibrary);
            this.panel1.Controls.Add(this.panelAddFunds);
            this.panel1.Controls.Add(this.panelProfile);
            this.panel1.Controls.Add(this.panelStore);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 816);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.labelAddFunds);
            this.panel2.Controls.Add(this.labelWallet);
            this.panel2.Controls.Add(this.labelLogout);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelProfile);
            this.panel2.Controls.Add(this.labelStore);
            this.panel2.Controls.Add(this.labelLibrary);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1476, 81);
            this.panel2.TabIndex = 1;
            // 
            // labelAddFunds
            // 
            this.labelAddFunds.AutoSize = true;
            this.labelAddFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddFunds.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddFunds.Location = new System.Drawing.Point(556, 29);
            this.labelAddFunds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddFunds.Name = "labelAddFunds";
            this.labelAddFunds.Size = new System.Drawing.Size(114, 25);
            this.labelAddFunds.TabIndex = 7;
            this.labelAddFunds.Text = "ADD FUNDS";
            this.labelAddFunds.Click += new System.EventHandler(this.labelAddFunds_Click);
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWallet.Location = new System.Drawing.Point(1160, 30);
            this.labelWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(128, 25);
            this.labelWallet.TabIndex = 6;
            this.labelWallet.Text = "WALLET: 100€";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(1314, 30);
            this.labelLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(84, 25);
            this.labelLogout.TabIndex = 4;
            this.labelLogout.Text = "LOGOUT";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(20, 24);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(205, 30);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "EMAIL@EMAIL.COM";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(466, 30);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(81, 25);
            this.labelProfile.TabIndex = 2;
            this.labelProfile.Text = "PROFILE";
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(388, 29);
            this.labelStore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(66, 25);
            this.labelStore.TabIndex = 1;
            this.labelStore.Text = "STORE";
            this.labelStore.Click += new System.EventHandler(this.labelStore_Click);
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLibrary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrary.Location = new System.Drawing.Point(299, 29);
            this.labelLibrary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(82, 25);
            this.labelLibrary.TabIndex = 0;
            this.labelLibrary.Text = "LIBRARY";
            this.labelLibrary.Click += new System.EventHandler(this.labelLibrary_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.PanelHeader.Controls.Add(this.panel3);
            this.PanelHeader.Controls.Add(this.LabelClose);
            this.PanelHeader.Controls.Add(this.LabelMinimize);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Location = new System.Drawing.Point(0, 2);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1476, 57);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1476, 29);
            this.panel3.TabIndex = 15;
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClose.Location = new System.Drawing.Point(1436, 0);
            this.LabelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(29, 30);
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
            this.LabelMinimize.Location = new System.Drawing.Point(1413, -7);
            this.LabelMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMinimize.Name = "LabelMinimize";
            this.LabelMinimize.Size = new System.Drawing.Size(25, 32);
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
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game client";
            // 
            // panelAddFunds
            // 
            this.panelAddFunds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelAddFunds.Controls.Add(this.label14);
            this.panelAddFunds.Controls.Add(this.label12);
            this.panelAddFunds.Controls.Add(this.textBoxAmount);
            this.panelAddFunds.Controls.Add(this.button4);
            this.panelAddFunds.Controls.Add(this.buttonSubmitAddFunds);
            this.panelAddFunds.Controls.Add(this.panel6);
            this.panelAddFunds.Controls.Add(this.label13);
            this.panelAddFunds.Location = new System.Drawing.Point(91, 158);
            this.panelAddFunds.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddFunds.Name = "panelAddFunds";
            this.panelAddFunds.Size = new System.Drawing.Size(1303, 634);
            this.panelAddFunds.TabIndex = 5;
            this.panelAddFunds.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(315, 21);
            this.label14.TabIndex = 60;
            this.label14.Text = "* Maximum amount per transaction is 100€.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "AMMOUNT:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxAmount.Location = new System.Drawing.Point(238, 227);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.MaxLength = 3;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(341, 28);
            this.textBoxAmount.TabIndex = 57;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(231, 226);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 30);
            this.button4.TabIndex = 59;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonSubmitAddFunds
            // 
            this.buttonSubmitAddFunds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonSubmitAddFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmitAddFunds.Enabled = false;
            this.buttonSubmitAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitAddFunds.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitAddFunds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmitAddFunds.Location = new System.Drawing.Point(231, 286);
            this.buttonSubmitAddFunds.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitAddFunds.Name = "buttonSubmitAddFunds";
            this.buttonSubmitAddFunds.Size = new System.Drawing.Size(355, 65);
            this.buttonSubmitAddFunds.TabIndex = 56;
            this.buttonSubmitAddFunds.Text = "SUBMIT";
            this.buttonSubmitAddFunds.UseVisualStyleBackColor = false;
            this.buttonSubmitAddFunds.Click += new System.EventHandler(this.buttonSubmitAddFunds_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(99, 102);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 2);
            this.panel6.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 50);
            this.label13.TabIndex = 54;
            this.label13.Text = "ADD FUNDS";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelProfile.Controls.Add(this.labelPasswordFormatError);
            this.panelProfile.Controls.Add(this.labelPasswordsDontMatchError);
            this.panelProfile.Controls.Add(this.labelOldPasswordError);
            this.panelProfile.Controls.Add(this.label10);
            this.panelProfile.Controls.Add(this.textBoxConfirmPassword);
            this.panelProfile.Controls.Add(this.button2);
            this.panelProfile.Controls.Add(this.label9);
            this.panelProfile.Controls.Add(this.textBoxNewPassword);
            this.panelProfile.Controls.Add(this.button1);
            this.panelProfile.Controls.Add(this.label8);
            this.panelProfile.Controls.Add(this.textBoxOldPassword);
            this.panelProfile.Controls.Add(this.buttonErrorName);
            this.panelProfile.Controls.Add(this.checkBoxShowPassword);
            this.panelProfile.Controls.Add(this.buttonProfileSubmit);
            this.panelProfile.Controls.Add(this.label7);
            this.panelProfile.Controls.Add(this.labelProfilePhone);
            this.panelProfile.Controls.Add(this.labelProfileEmail);
            this.panelProfile.Controls.Add(this.labelProfileLastName);
            this.panelProfile.Controls.Add(this.labelProfileName);
            this.panelProfile.Controls.Add(this.panel5);
            this.panelProfile.Controls.Add(this.label6);
            this.panelProfile.Controls.Add(this.label5);
            this.panelProfile.Controls.Add(this.label4);
            this.panelProfile.Controls.Add(this.label3);
            this.panelProfile.Controls.Add(this.panel4);
            this.panelProfile.Controls.Add(this.label2);
            this.panelProfile.Location = new System.Drawing.Point(91, 158);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(1305, 636);
            this.panelProfile.TabIndex = 2;
            this.panelProfile.Visible = false;
            this.panelProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfile_Paint);
            // 
            // labelPasswordFormatError
            // 
            this.labelPasswordFormatError.AutoSize = true;
            this.labelPasswordFormatError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordFormatError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordFormatError.Location = new System.Drawing.Point(190, 366);
            this.labelPasswordFormatError.Name = "labelPasswordFormatError";
            this.labelPasswordFormatError.Size = new System.Drawing.Size(269, 24);
            this.labelPasswordFormatError.TabIndex = 62;
            this.labelPasswordFormatError.Text = "Minimum password length is 8.";
            this.labelPasswordFormatError.Visible = false;
            // 
            // labelPasswordsDontMatchError
            // 
            this.labelPasswordsDontMatchError.AutoSize = true;
            this.labelPasswordsDontMatchError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordsDontMatchError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordsDontMatchError.Location = new System.Drawing.Point(190, 366);
            this.labelPasswordsDontMatchError.Name = "labelPasswordsDontMatchError";
            this.labelPasswordsDontMatchError.Size = new System.Drawing.Size(208, 24);
            this.labelPasswordsDontMatchError.TabIndex = 61;
            this.labelPasswordsDontMatchError.Text = "Passwords don\'t match.";
            this.labelPasswordsDontMatchError.Visible = false;
            // 
            // labelOldPasswordError
            // 
            this.labelOldPasswordError.AutoSize = true;
            this.labelOldPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelOldPasswordError.Location = new System.Drawing.Point(187, 366);
            this.labelOldPasswordError.Name = "labelOldPasswordError";
            this.labelOldPasswordError.Size = new System.Drawing.Size(227, 24);
            this.labelOldPasswordError.TabIndex = 60;
            this.labelOldPasswordError.Text = "Old password is incorrect.";
            this.labelOldPasswordError.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(783, 425);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "CONFIRM PASSWORD";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(974, 420);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmPassword.MaxLength = 50;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(191, 28);
            this.textBoxConfirmPassword.TabIndex = 57;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(967, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 30);
            this.button2.TabIndex = 59;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 21);
            this.label9.TabIndex = 55;
            this.label9.Text = "NEW PASSWORD";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxNewPassword.Location = new System.Drawing.Point(558, 419);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewPassword.MaxLength = 50;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(191, 28);
            this.textBoxNewPassword.TabIndex = 54;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(551, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 30);
            this.button1.TabIndex = 56;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "OLD PASSWORD";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxOldPassword.Location = new System.Drawing.Point(194, 418);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOldPassword.MaxLength = 50;
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(191, 28);
            this.textBoxOldPassword.TabIndex = 51;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            this.textBoxOldPassword.Enter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // buttonErrorName
            // 
            this.buttonErrorName.BackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonErrorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrorName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonErrorName.Location = new System.Drawing.Point(187, 417);
            this.buttonErrorName.Margin = new System.Windows.Forms.Padding(2);
            this.buttonErrorName.Name = "buttonErrorName";
            this.buttonErrorName.Size = new System.Drawing.Size(205, 30);
            this.buttonErrorName.TabIndex = 53;
            this.buttonErrorName.TabStop = false;
            this.buttonErrorName.UseVisualStyleBackColor = false;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(187, 480);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(184, 34);
            this.checkBoxShowPassword.TabIndex = 50;
            this.checkBoxShowPassword.TabStop = false;
            this.checkBoxShowPassword.Text = "Show passwords";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonProfileSubmit
            // 
            this.buttonProfileSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.buttonProfileSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfileSubmit.Enabled = false;
            this.buttonProfileSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfileSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfileSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProfileSubmit.Location = new System.Drawing.Point(969, 508);
            this.buttonProfileSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfileSubmit.Name = "buttonProfileSubmit";
            this.buttonProfileSubmit.Size = new System.Drawing.Size(205, 65);
            this.buttonProfileSubmit.TabIndex = 48;
            this.buttonProfileSubmit.Text = "SUBMIT CHANGE";
            this.buttonProfileSubmit.UseVisualStyleBackColor = false;
            this.buttonProfileSubmit.Click += new System.EventHandler(this.buttonProfileSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "CHANGE PASSWORD";
            // 
            // labelProfilePhone
            // 
            this.labelProfilePhone.AutoSize = true;
            this.labelProfilePhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilePhone.Location = new System.Drawing.Point(873, 220);
            this.labelProfilePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfilePhone.Name = "labelProfilePhone";
            this.labelProfilePhone.Size = new System.Drawing.Size(151, 32);
            this.labelProfilePhone.TabIndex = 23;
            this.labelProfilePhone.Text = "060/123-123";
            // 
            // labelProfileEmail
            // 
            this.labelProfileEmail.AutoSize = true;
            this.labelProfileEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileEmail.Location = new System.Drawing.Point(270, 220);
            this.labelProfileEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfileEmail.Name = "labelProfileEmail";
            this.labelProfileEmail.Size = new System.Drawing.Size(254, 32);
            this.labelProfileEmail.TabIndex = 22;
            this.labelProfileEmail.Text = "johnsmith@email.com";
            // 
            // labelProfileLastName
            // 
            this.labelProfileLastName.AutoSize = true;
            this.labelProfileLastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileLastName.Location = new System.Drawing.Point(812, 136);
            this.labelProfileLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfileLastName.Name = "labelProfileLastName";
            this.labelProfileLastName.Size = new System.Drawing.Size(77, 32);
            this.labelProfileLastName.TabIndex = 21;
            this.labelProfileLastName.Text = "Smith";
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(147, 136);
            this.labelProfileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(66, 32);
            this.labelProfileName.TabIndex = 20;
            this.labelProfileName.Text = "John";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(56, 344);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 2);
            this.panel5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "PHONE NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "EMAIL ADDRESS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "LASTNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "NAME:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(60, 87);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 2);
            this.panel4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "USER PROFILE";
            // 
            // panelStore
            // 
            this.panelStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelStore.Controls.Add(this.flowLayoutPanelStore);
            this.panelStore.Controls.Add(this.textBoxStoreSearch);
            this.panelStore.Controls.Add(this.button3);
            this.panelStore.Controls.Add(this.label11);
            this.panelStore.Location = new System.Drawing.Point(91, 158);
            this.panelStore.Margin = new System.Windows.Forms.Padding(2);
            this.panelStore.Name = "panelStore";
            this.panelStore.Size = new System.Drawing.Size(1307, 638);
            this.panelStore.TabIndex = 4;
            this.panelStore.Visible = false;
            // 
            // flowLayoutPanelStore
            // 
            this.flowLayoutPanelStore.AutoScroll = true;
            this.flowLayoutPanelStore.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelStore.Location = new System.Drawing.Point(68, 93);
            this.flowLayoutPanelStore.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelStore.Name = "flowLayoutPanelStore";
            this.flowLayoutPanelStore.Size = new System.Drawing.Size(1185, 527);
            this.flowLayoutPanelStore.TabIndex = 56;
            this.flowLayoutPanelStore.WrapContents = false;
            // 
            // textBoxStoreSearch
            // 
            this.textBoxStoreSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxStoreSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStoreSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStoreSearch.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxStoreSearch.Location = new System.Drawing.Point(223, 40);
            this.textBoxStoreSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStoreSearch.MaxLength = 50;
            this.textBoxStoreSearch.Name = "textBoxStoreSearch";
            this.textBoxStoreSearch.Size = new System.Drawing.Size(301, 20);
            this.textBoxStoreSearch.TabIndex = 54;
            this.textBoxStoreSearch.TextChanged += new System.EventHandler(this.textBoxStoreSearch_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(217, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 24);
            this.button3.TabIndex = 55;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search games:";
            // 
            // panelLibrary
            // 
            this.panelLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.panelLibrary.Controls.Add(this.flowLayoutPanelLibrary);
            this.panelLibrary.Controls.Add(this.textBoxSearchLibrary);
            this.panelLibrary.Controls.Add(this.button5);
            this.panelLibrary.Controls.Add(this.label15);
            this.panelLibrary.Location = new System.Drawing.Point(91, 158);
            this.panelLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(1305, 636);
            this.panelLibrary.TabIndex = 3;
            // 
            // flowLayoutPanelLibrary
            // 
            this.flowLayoutPanelLibrary.AutoScroll = true;
            this.flowLayoutPanelLibrary.Controls.Add(this.labelNoGamesInLibrary);
            this.flowLayoutPanelLibrary.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelLibrary.Location = new System.Drawing.Point(62, 85);
            this.flowLayoutPanelLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelLibrary.Name = "flowLayoutPanelLibrary";
            this.flowLayoutPanelLibrary.Size = new System.Drawing.Size(1185, 527);
            this.flowLayoutPanelLibrary.TabIndex = 60;
            this.flowLayoutPanelLibrary.WrapContents = false;
            // 
            // textBoxSearchLibrary
            // 
            this.textBoxSearchLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.textBoxSearchLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchLibrary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchLibrary.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxSearchLibrary.Location = new System.Drawing.Point(217, 32);
            this.textBoxSearchLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchLibrary.MaxLength = 50;
            this.textBoxSearchLibrary.Name = "textBoxSearchLibrary";
            this.textBoxSearchLibrary.Size = new System.Drawing.Size(301, 20);
            this.textBoxSearchLibrary.TabIndex = 58;
            this.textBoxSearchLibrary.TextChanged += new System.EventHandler(this.textBoxSearchLibrary_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Location = new System.Drawing.Point(211, 31);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(316, 24);
            this.button5.TabIndex = 59;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(57, 24);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 30);
            this.label15.TabIndex = 57;
            this.label15.Text = "Search games:";
            // 
            // labelNoGamesInLibrary
            // 
            this.labelNoGamesInLibrary.AutoSize = true;
            this.labelNoGamesInLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGamesInLibrary.Location = new System.Drawing.Point(3, 0);
            this.labelNoGamesInLibrary.Name = "labelNoGamesInLibrary";
            this.labelNoGamesInLibrary.Size = new System.Drawing.Size(825, 24);
            this.labelNoGamesInLibrary.TabIndex = 1;
            this.labelNoGamesInLibrary.Text = "You don\'t have any games in your library. You can buy games or add free to play g" +
    "ames to library.";
            this.labelNoGamesInLibrary.Visible = false;
            // 
            // GameClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 821);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameClientForm";
            this.Load += new System.EventHandler(this.GameClientForm_Load);
            this.PanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panelAddFunds.ResumeLayout(false);
            this.panelAddFunds.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelStore.ResumeLayout(false);
            this.panelStore.PerformLayout();
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.flowLayoutPanelLibrary.ResumeLayout(false);
            this.flowLayoutPanelLibrary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label LabelMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Label labelAddFunds;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelStore;
        private System.Windows.Forms.Panel panelAddFunds;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProfilePhone;
        private System.Windows.Forms.Label labelProfileEmail;
        private System.Windows.Forms.Label labelProfileLastName;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonProfileSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Button buttonErrorName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStore;
        private System.Windows.Forms.TextBox textBoxStoreSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPasswordsDontMatchError;
        private System.Windows.Forms.Label labelOldPasswordError;
        private System.Windows.Forms.Label labelPasswordFormatError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSubmitAddFunds;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLibrary;
        private System.Windows.Forms.TextBox textBoxSearchLibrary;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNoGamesInLibrary;
    }
}