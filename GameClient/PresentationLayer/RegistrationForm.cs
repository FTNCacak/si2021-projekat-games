using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLastname.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                CheckEmptyFields();
                return;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.UseSystemPasswordChar = false;
            }
            else {
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
            List<Button> buttons = new List<Button>() {buttonErrorName, buttonErrorLastname, buttonErrorEmail, buttonErrorPhone, buttonErrorPassword, buttonErrorConfirmPassword };
            List<Label> labels = new List<Label>() { labelErrorFormat, labelErrorEmpty, labelFormatName, labelFormatLastaname, labelFormatEmail, labelFormatPhone, labelFormatPassword, labelFormatConfirmPassword };
            ResetFormatStyles(buttons, labels);
        }
    }
}
