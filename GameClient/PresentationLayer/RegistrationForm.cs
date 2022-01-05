using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using Shared.Interfaces;
using System.Threading;

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserBusiness userBusiness;
        public RegistrationForm(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness;
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void LabelMinimize_MouseHover(object sender, EventArgs e)
        {
            LabelMinimize.ForeColor = Color.White;
        }

        private void LabelClose_MouseHover(object sender, EventArgs e)
        {
            LabelClose.ForeColor = Color.White;
        }

        private void LabelMinimize_MouseLeave(object sender, EventArgs e)
        {
            LabelMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            LabelClose.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void LabelMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CheckEmptyFields()
        {
            if (textBoxName.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorName.ForeColor = Color.Red;
            }
            if (textBoxLastname.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorLastname.ForeColor = Color.Red;
            }
            if (textBoxEmail.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorEmail.ForeColor = Color.Red;
            }
            if (textBoxPhone.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorPhone.ForeColor = Color.Red;
            }
            if (textBoxPassword.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorPassword.ForeColor = Color.Red;
            }
            if (textBoxConfirmPassword.Text == "")
            {
                labelErrorEmpty.Visible = true;
                buttonErrorConfirmPassword.ForeColor = Color.Red;
            }
        }

        public void CheckFieldsFormat()
        {
            if (!userBusiness.NameAndLastNameFormatValidation(textBoxName.Text))
            {
                labelErrorFormat.Visible = true;
                labelFormatName.Visible = true;
                buttonErrorName.ForeColor = Color.Red;
            }
            if (!userBusiness.NameAndLastNameFormatValidation(textBoxLastname.Text))
            {
                labelErrorFormat.Visible = true;
                labelFormatLastaname.Visible = true;
                buttonErrorLastname.ForeColor = Color.Red;
            }
            if (!userBusiness.EmailFormatValidation(textBoxEmail.Text))
            {
                labelErrorFormat.Visible = true;
                labelFormatEmail.Visible = true;
                buttonErrorEmail.ForeColor = Color.Red;
            }
            if (!userBusiness.PhoneFormatValidation(textBoxPhone.Text))
            {
                labelErrorFormat.Visible = true;
                labelFormatPhone.Visible = true;
                buttonErrorPhone.ForeColor = Color.Red;
            }
            if (textBoxPassword.Text.Length < 8)
            {
                labelErrorFormat.Visible = true;
                labelFormatPassword.Visible = true;
                buttonErrorPassword.ForeColor = Color.Red;
            }
            if (textBoxConfirmPassword.Text != textBoxPassword.Text)
            {
                labelErrorFormat.Visible = true;
                labelFormatConfirmPassword.Visible = true;
                buttonErrorConfirmPassword.ForeColor = Color.Red;
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLastname.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                CheckEmptyFields();
                return;
            }

            if (userBusiness.IsUserAlreadyExists(textBoxEmail.Text))
            {
                labelEmailExists.Visible = true;
                linkLabelLogin.Visible = true;
                labelQuestionMark.Visible = true;
                return;

            }
            if (!userBusiness.NameAndLastNameFormatValidation(textBoxName.Text) || !userBusiness.NameAndLastNameFormatValidation(textBoxLastname.Text) || !userBusiness.EmailFormatValidation(textBoxEmail.Text) || !userBusiness.PhoneFormatValidation(textBoxPhone.Text) || textBoxPassword.Text.Length < 8 || textBoxConfirmPassword.Text != textBoxPassword.Text)
            {
                CheckFieldsFormat();
                return;
            }

            string name = textBoxName.Text;
            string lastname = textBoxLastname.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string password = textBoxPassword.Text;

            User user = new User(name, lastname, email, password, phone, 0);


            userBusiness.InsertUser(user);

            MessageBox.Show("Successful registration. Now you can login to your account.");


            Thread thread = new Thread(() => OpenNewForm(userBusiness));
            thread.Start();
            this.Dispose();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        public void ResetFormatStyles(List<Button> buttons, List<Label> labels)
        {
            foreach (var item in buttons)
            {
                item.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            }

            foreach (var item in labels)
            {
                item.Visible = false;
            }


        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>() { buttonErrorName, buttonErrorLastname, buttonErrorEmail, buttonErrorPhone, buttonErrorPassword, buttonErrorConfirmPassword };
            List<Label> labels = new List<Label>() { labelErrorFormat, labelErrorEmpty, labelFormatName, labelFormatLastaname, labelFormatEmail, labelFormatPhone, labelFormatPassword, labelFormatConfirmPassword, labelEmailExists, linkLabelLogin, labelQuestionMark };
            ResetFormatStyles(buttons, labels);
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Thread thread = new Thread(() => OpenNewForm(userBusiness));
            thread.Start();
            this.Dispose();

        }

        private void OpenNewForm(IUserBusiness userBusiness)
        {
            Application.Run(new LoginForm(userBusiness));
        }
    }
}
