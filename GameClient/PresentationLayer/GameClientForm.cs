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
using System.IO;
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public partial class GameClientForm : Form
    {


        private readonly IUserBusiness userBusiness;
        private readonly IGameBusiness gameBusiness;
        private User user;
        private List<Game> storeGames;
        private List<Sale> sales;
        public GameClientForm(IUserBusiness _userBusiness, IGameBusiness _gameBusiness, User user, List<Game> storeGames, List<Sale> sales)
        {
            this.userBusiness = _userBusiness;
            this.gameBusiness = _gameBusiness;
            this.user = user;
            this.storeGames = storeGames;
            this.sales = sales;
            InitializeComponent();
        }


        private void GameClientForm_Load(object sender, EventArgs e)
        {
            labelProfileName.Text = user.Name;
            labelProfileLastName.Text = user.Lastname;
            labelProfileEmail.Text = user.Email;
            labelProfilePhone.Text = user.Phone;
            labelEmail.Text = user.Email.ToUpper();
            labelWallet.Text = $"WALLET {user.Wallet}€";


            if (sales.Count > 0)
            {
                List<Game> games = GamesOwnedByUser(storeGames, sales);
                FillFlowLayoutLibrary(games);
            }
            else {

                labelNoGamesInLibrary.Visible = true;
            }
            FillFlowLayoutStore(storeGames);
        }


        public void FillFlowLayoutStore(List<Game> games)
        {

            foreach (Game game in games)
            {
                Panel panel = new Panel();
                panel.Name = $"panelStore{game.GameID}";
                panel.Width = 1100;
                panel.Height = 250;
                panel.BackColor = Color.FromArgb(42, 46, 49);
                panel.Margin = new Padding(0, 0, 0, 20);


                PictureBox pictureBox = new PictureBox();
                Image image = ConvertByteArrayToImage(game.GameImage);
                pictureBox.Width = 350;
                pictureBox.Height = 250;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.BackgroundImage = image;
                panel.Controls.Add(pictureBox);


                Label labelTitle = new Label();

                labelTitle.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTitle.Text = game.Title;
                labelTitle.AutoSize = true;
                labelTitle.Left = 370;
                labelTitle.Top = 15;
                panel.Controls.Add(labelTitle);


                Label labelDescription = new Label();
                labelDescription.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelDescription.Text = game.Description;
                labelDescription.Width = 700;
                labelDescription.Height = 80;
                labelDescription.Left = 370;
                labelDescription.Top = 60;
                panel.Controls.Add(labelDescription);


                Label labelRealiseDate = new Label();
                labelRealiseDate.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string dateFromDataBase = game.ReleaseDate.ToString("dd MMMM, yyyy");
                string date = dateFromDataBase.StartsWith("0") ? dateFromDataBase.Substring(1, dateFromDataBase.Length - 1) : dateFromDataBase;
                labelRealiseDate.Text = $"RELEASE DATE: {date}";
                labelRealiseDate.Left = 370;
                labelRealiseDate.Top = 140;
                labelRealiseDate.AutoSize = true;
                panel.Controls.Add(labelRealiseDate);

                Label labelPublisher = new Label();
                labelPublisher.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPublisher.Text = $"PUBLISHER: {game.Publisher}";
                labelPublisher.Left = 370;
                labelPublisher.Top = 170;
                labelPublisher.AutoSize = true;
                panel.Controls.Add(labelPublisher);

                Label labelDeveloper = new Label();
                labelDeveloper.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelDeveloper.Text = $"DEVELOPER: {game.Developer}";
                labelDeveloper.Left = 600;
                labelDeveloper.Top = 170;
                labelDeveloper.AutoSize = true;
                panel.Controls.Add(labelDeveloper);

                Label labelPrice = new Label();
                labelPrice.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                string labelPriceText = game.Price == 0 ? "FREE TO PLAY" : $"PRICE: {game.Price}€";

                if (game.Price == 0)
                {
                    labelPrice.ForeColor = Color.Green;
                }

                labelPrice.Text = $"{labelPriceText}";
                labelPrice.Left = 370;
                labelPrice.Top = 200;
                labelPrice.AutoSize = true;
                panel.Controls.Add(labelPrice);

                Button button = new Button();
                button.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Padding = new System.Windows.Forms.Padding(2);
                button.ForeColor = Color.White;
                button.BackColor = Color.Green;

                if (IsGameOwnedByUser(sales, game.GameID))
                {
                    button.Text = "OWNED";
                }
                else
                {
                    if (game.Price == 0)
                    {
                        button.Name = $"buttonAddFreeGame{game.GameID}";
                        button.Text = "ADD TO LIBRARY";
                        button.Click += buttonAddFreeGame_Click;
                    }
                    else
                    {
                        button.Name = $"buttonBuyGame{game.GameID}";
                        button.Text = "BUY GAME";
                        button.Click += buttonBuyGame_Click;

                    }
                }

                button.Left = 900;
                button.Top = 200;
                button.Width = 150;
                button.AutoSize = true;



                panel.Controls.Add(button);



                flowLayoutPanelStore.Controls.Add(panel);
            }


        }



        public void FillFlowLayoutLibrary(List<Game> games)
        {

            foreach (Game game in games)
            {
                Panel panel = new Panel();
                panel.Name = $"panelLibrary{game.GameID}";
                panel.Width = 1100;
                panel.Height = 250;
                panel.BackColor = Color.FromArgb(42, 46, 49);
                panel.Margin = new Padding(0, 0, 0, 20);


                PictureBox pictureBox = new PictureBox();
                Image image = ConvertByteArrayToImage(game.GameImage);
                pictureBox.Width = 350;
                pictureBox.Height = 250;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.BackgroundImage = image;
                panel.Controls.Add(pictureBox);


                Label labelTitle = new Label();

                labelTitle.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTitle.Text = game.Title;
                labelTitle.AutoSize = true;
                labelTitle.Left = 370;
                labelTitle.Top = 15;
                panel.Controls.Add(labelTitle);


                Label labelDescription = new Label();
                labelDescription.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelDescription.Text = game.Description;
                labelDescription.Width = 700;
                labelDescription.Height = 80;
                labelDescription.Left = 370;
                labelDescription.Top = 60;
                panel.Controls.Add(labelDescription);


                Label labelRealiseDate = new Label();
                labelRealiseDate.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string dateFromDataBase = game.ReleaseDate.ToString("dd MMMM, yyyy");
                string date = dateFromDataBase.StartsWith("0") ? dateFromDataBase.Substring(1, dateFromDataBase.Length - 1) : dateFromDataBase;
                labelRealiseDate.Text = $"RELEASE DATE: {date}";
                labelRealiseDate.Left = 370;
                labelRealiseDate.Top = 140;
                labelRealiseDate.AutoSize = true;
                panel.Controls.Add(labelRealiseDate);

                Label labelPublisher = new Label();
                labelPublisher.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPublisher.Text = $"PUBLISHER: {game.Publisher}";
                labelPublisher.Left = 370;
                labelPublisher.Top = 170;
                labelPublisher.AutoSize = true;
                panel.Controls.Add(labelPublisher);

                Label labelDeveloper = new Label();
                labelDeveloper.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelDeveloper.Text = $"DEVELOPER: {game.Developer}";
                labelDeveloper.Left = 600;
                labelDeveloper.Top = 170;
                labelDeveloper.AutoSize = true;
                panel.Controls.Add(labelDeveloper);




                Label labelBuyDate = new Label();
                labelRealiseDate.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DateTime buyDate = GetGameBuyDate(sales, game.GameID);
                string dateFromDataBaseBuyDate = buyDate.ToString("dd MMMM, yyyy");
                string date2 = dateFromDataBaseBuyDate.StartsWith("0") ? dateFromDataBaseBuyDate.Substring(1, dateFromDataBaseBuyDate.Length - 1) : dateFromDataBaseBuyDate;

                labelBuyDate.Text = $"OWNER SINCE: {date2}";
                labelBuyDate.Left = 370;
                labelBuyDate.Top = 200;
                labelBuyDate.AutoSize = true;
                panel.Controls.Add(labelBuyDate);

                Button button = new Button();
                button.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Padding = new System.Windows.Forms.Padding(2);
                button.ForeColor = Color.White;
                button.BackColor = Color.Green;
                button.Text = "PLAY";
                button.Left = 730;
                button.Top = 200;
                button.Width = 150;
                button.AutoSize = true;

                panel.Controls.Add(button);

                Button buttonDelete = new Button();
                buttonDelete.Name = $"buttonDelete{game.GameID}";
                buttonDelete.Click += buttonDeleteGameFromLibrary_Click;
                buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonDelete.Padding = new System.Windows.Forms.Padding(2);
                buttonDelete.ForeColor = Color.White;
                buttonDelete.BackColor = Color.Red;
                buttonDelete.Text = "DELETE";
                buttonDelete.Left = 900;
                buttonDelete.Top = 200;
                buttonDelete.Width = 150;
                buttonDelete.AutoSize = true;
               
              


                panel.Controls.Add(buttonDelete);



                flowLayoutPanelLibrary.Controls.Add(panel);
            }


        }

        public DateTime GetGameBuyDate(List<Sale> Sales, int GameID)
        {

            DateTime date = new DateTime();
            foreach (var item in Sales)
            {
                if (item.GameID == GameID)
                    date = item.SellDate;
            }

            return date;
        }

        public List<Game> GamesOwnedByUser(List<Game> storeGames, List<Sale> sales)
        {

            List<Game> games = new List<Game>();


            foreach (var sale in sales)
            {
                Game game = GetGameData(sale.GameID, storeGames);
                games.Add(game);
            }


            return games;
        }

        public bool IsGameOwnedByUser(List<Sale> sales, int GameID)
        {
            if (sales.Count == 0)
                return false;

            foreach (Sale sale in sales)
            {
                if (sale.GameID == GameID)
                    return true;
            }
            return false;
        }

        public Game GetGameData(int GameID, List<Game> games)
        {

            Game gameToReturn = new Game();
            foreach (Game game in games)
            {
                if (game.GameID == GameID)
                    gameToReturn = game;
            }

            return gameToReturn;

        }


        public void buttonBuyGame_Click(object sender, EventArgs e)
        {
            Button buttonBuyGame = sender as Button;

            string buttonName = buttonBuyGame.Name;


            string removedbuttonName = buttonName.Replace("buttonBuyGame", "");

            int GameID = Convert.ToInt32(removedbuttonName);

            Game game = GetGameData(GameID, storeGames);


            if (user.Wallet < game.Price)
            {
                MessageBox.Show($"You don't have enough money in your wallet to buy {game.Title}");
            }

            else
            {

                DateTime currentDate = DateTime.Now;

                gameBusiness.InsertIntoSales(user.UserID, GameID, currentDate);

                sales = gameBusiness.GetAllUserSales(user.UserID);

                userBusiness.UpdateUserWallet(user.UserID, user.Wallet - game.Price);

                user = userBusiness.GetUserData(user.Email);

                labelWallet.Text = $"WALLET {user.Wallet}€";

                flowLayoutPanelStore.Controls.Clear();
                flowLayoutPanelLibrary.Controls.Clear();

                List<Game> games = GamesOwnedByUser(storeGames, sales);
                FillFlowLayoutLibrary(games);

                FillFlowLayoutStore(storeGames);

                MessageBox.Show($"You bought game {game.Title}.");
            }



        }


        public void buttonDeleteGameFromLibrary_Click(object sender, EventArgs e)
        {
            Button buttonDelete = sender as Button;

            string buttonName = buttonDelete.Name;

            string removedbuttonName = buttonName.Replace("buttonDelete", "");

            int GameID = Convert.ToInt32(removedbuttonName);

            Game game = GetGameData(GameID, storeGames);



            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {game.Title} from library?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                gameBusiness.DeleteGameFromLibrary(user.UserID, GameID);
                sales = gameBusiness.GetAllUserSales(user.UserID);

                flowLayoutPanelStore.Controls.Clear();
                flowLayoutPanelLibrary.Controls.Clear();

                List<Game> games = GamesOwnedByUser(storeGames, sales);


                if (sales.Count > 0)
                {
           
                    FillFlowLayoutLibrary(games);
                    SearchByName(textBoxSearchLibrary.Text, "panelLibrary", textBoxSearchLibrary, flowLayoutPanelLibrary, games);
                }
                else
                {

                    labelNoGamesInLibrary.Visible = true;
                }

                FillFlowLayoutStore(storeGames);

              

            }


            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

            public void buttonAddFreeGame_Click(object sender, EventArgs e)
        {
            Button buttonAddFreeGame = sender as Button;

            string buttonName = buttonAddFreeGame.Name;


            string removedbuttonName = buttonName.Replace("buttonAddFreeGame", "");

            int GameID = Convert.ToInt32(removedbuttonName);

            DateTime currentDate = DateTime.Now;

            gameBusiness.InsertIntoSales(user.UserID, GameID, currentDate);

            sales = gameBusiness.GetAllUserSales(user.UserID);

            Game game = GetGameData(GameID, storeGames);


           

            flowLayoutPanelStore.Controls.Clear();
            flowLayoutPanelLibrary.Controls.Clear();

            List<Game> games = GamesOwnedByUser(storeGames, sales);
            FillFlowLayoutLibrary(games);


            FillFlowLayoutStore(storeGames);

            MessageBox.Show($"You added {game.Title} to your library.");

        }

        public Image ConvertByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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

        public void ChangePanels(string panelName)
        {
            if (panelName == "Library")
            {
                panelLibrary.Visible = true;
                panelStore.Visible = false;
                panelProfile.Visible = false;
                panelAddFunds.Visible = false;
                return;
            }
            if (panelName == "Store")
            {
                panelLibrary.Visible = false;
                panelStore.Visible = true;
                panelProfile.Visible = false;
                panelAddFunds.Visible = false;
                return;
            }
            if (panelName == "Profile")
            {
                panelLibrary.Visible = false;
                panelStore.Visible = false;
                panelProfile.Visible = true;
                panelAddFunds.Visible = false;
                return;
            }
            if (panelName == "AddFunds")
            {
                panelLibrary.Visible = false;
                panelStore.Visible = false;
                panelProfile.Visible = false;
                panelAddFunds.Visible = true;
                return;
            }
        }

        private void labelLibrary_Click(object sender, EventArgs e)
        {
            ChangePanels("Library");
        }

        private void labelStore_Click(object sender, EventArgs e)
        {
            ChangePanels("Store");
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            ChangePanels("Profile");
        }

        private void labelAddFunds_Click(object sender, EventArgs e)
        {
            ChangePanels("AddFunds");
        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.Checked)
            {
                textBoxOldPassword.UseSystemPasswordChar = false;
                textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.UseSystemPasswordChar = false;


            }
            else
            {
                textBoxOldPassword.UseSystemPasswordChar = true;
                textBoxNewPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void OpenNewForm(IUserBusiness userBusiness, IGameBusiness gameBusiness)
        {
            Application.Run(new LoginForm(userBusiness, gameBusiness));
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm(userBusiness, gameBusiness));
            thread.Start();
            this.Dispose();
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text.Length > 0 && textBoxOldPassword.Text.Length > 0)
            {
                buttonProfileSubmit.Enabled = true;
            }
            else
            {
                buttonProfileSubmit.Enabled = false;
            }
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            labelPasswordsDontMatchError.Visible = false;
            labelOldPasswordError.Visible = false;
            labelPasswordFormatError.Visible = false;
        }

        private void buttonProfileSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (oldPassword != user.Password)
            {
                labelOldPasswordError.Visible = true;
                return;
            }
            if (newPassword.Length < 8)
            {
                labelPasswordFormatError.Visible = true;
                return;
            }
            if (newPassword != confirmPassword)
            {
                labelPasswordsDontMatchError.Visible = true;
                return;
            }

            userBusiness.UpdateUserPassword(user.UserID, newPassword);

            user = userBusiness.GetUserData(user.Email);


            MessageBox.Show("Your password is changed.");

            textBoxOldPassword.Clear();
            textBoxConfirmPassword.Clear();
            textBoxNewPassword.Clear();

        }

        private void buttonSubmitAddFunds_Click(object sender, EventArgs e)
        {

            decimal amount = Convert.ToDecimal(textBoxAmount.Text);

            userBusiness.UpdateUserWallet(user.UserID, amount + user.Wallet);

            user = userBusiness.GetUserData(user.Email);

            labelWallet.Text = $"WALLET {user.Wallet}€";

            textBoxAmount.Clear();


        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

            Regex pattern = new Regex(@"^(?:[1-9]\d?|100)$");

            string amountString = textBoxAmount.Text;

            if (pattern.Match(amountString).Success)
            {
                buttonSubmitAddFunds.Enabled = true;
            }
            else
            {
                buttonSubmitAddFunds.Enabled = false;
            }
        }


        public void SearchByName(string nameToSearch, string panelName, TextBox textBox,  FlowLayoutPanel flowLayoutPanel, List<Game> games)
        {
            if (nameToSearch.Length != 0)
            {
                foreach (var item in games)
                {
                    Control panelToHide = flowLayoutPanel.Controls.Find($"{panelName}{item.GameID}", true)[0];
                    if (!item.Title.StartsWith(nameToSearch, StringComparison.OrdinalIgnoreCase))
                        panelToHide.Hide();
                    else
                    {

                        panelToHide.Show();
                    }

                }


            }
            else
            {
                textBox.Text = "";
                foreach (var item in games)
                {
                    Control panelToHide = flowLayoutPanel.Controls.Find($"{panelName}{item.GameID}", true)[0];
                    panelToHide.Show();

                }
            }
        }

        private void textBoxSearchLibrary_TextChanged(object sender, EventArgs e)
        {
            string nameToSearch = textBoxSearchLibrary.Text;
            List<Game> games = GamesOwnedByUser(storeGames, sales);
            SearchByName(nameToSearch, "panelLibrary", textBoxSearchLibrary, flowLayoutPanelLibrary, games);
        }

        private void textBoxStoreSearch_TextChanged(object sender, EventArgs e)
        {
            string nameToSearch = textBoxStoreSearch.Text;
            SearchByName(nameToSearch, "panelStore", textBoxStoreSearch, flowLayoutPanelStore, storeGames);
        }
    }
}
