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
    public partial class LoginForm : Form
    {

        private readonly IUserBusiness userBusiness;
        private readonly IGameBusiness gameBusiness;
        public LoginForm(IUserBusiness _userBusiness, IGameBusiness _gameBusiness)
        {
            this.userBusiness = _userBusiness;
            this.gameBusiness = _gameBusiness;
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

        private void buttonLinkToRegister_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm(userBusiness, gameBusiness));
            thread.Start();
            this.Dispose();
        }

        private void OpenNewForm(IUserBusiness userBusiness, IGameBusiness gameBusiness)
        {
            Application.Run(new RegistrationForm(userBusiness, gameBusiness));
        }

        private void OpenNewGameClientForm(IUserBusiness userBusiness, IGameBusiness gameBusiness, User user, List<Game> storeGames, List<Sale> sales)
        {
            Application.Run(new GameClientForm(userBusiness, gameBusiness, user, storeGames, sales));
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (!userBusiness.LoginValidation(email, password))
            {
                labelError.Visible = true;
                return;
            }
            else
            {
                User user = userBusiness.GetUserData(email);
                List<Game> storeGames = gameBusiness.GetAllGames();
                List<Sale> sales = gameBusiness.GetAllUserSales(user.UserID);
                Thread thread = new Thread(() => OpenNewGameClientForm(userBusiness, gameBusiness, user, storeGames, sales));
                thread.Start();
                this.Dispose();
            }



        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }



        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }
    }
}

