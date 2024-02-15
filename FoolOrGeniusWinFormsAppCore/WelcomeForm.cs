using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using FoolOrGenius.Db;
using FoolOrGenius.Db.Models;
using FoolOrGeniusWinFormsApp.FruitNinja;

namespace FoolOrGeniusWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        DatabaseContext db;
        UserFactory userFactory;
        private mainForm mainForm;
        public WelcomeForm(DatabaseContext db, UserFactory userFactory, mainForm mainForm)
        {
            InitializeComponent();

            userLoginField.Text = "Login";
            userLoginField.ForeColor = Color.Gray;

            userPasswordField.Text = "Password";
            userPasswordField.ForeColor = Color.Gray;

            this.userPasswordField.AutoSize = false;
            this.userPasswordField.Size = new Size(300, 60);
            this.userLoginField.AutoSize = false;
            this.userLoginField.Size = new Size(300, 60);

            this.db = db;
            this.userFactory = userFactory;
            this.mainForm = mainForm;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.Text = "";


        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void addNewQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newQuestionForm = new AddNewQuestionForm();
            newQuestionForm.ShowDialog();
        }

        private void listOfAllQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionListForm = new QuestionsListForm();
            questionListForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void passwordFieldTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.Blue;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.White;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private Point lastPoint;
        private void WelcomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void WelcomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorizationLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void authorizationLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorizationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userLogin_Enter(object sender, EventArgs e)
        {

            if (userLoginField.Text == "Login")
            {
                userLoginField.Text = "";
                userLoginField.ForeColor = Color.Black;
            }
        }

        private void userLogin_Leave(object sender, EventArgs e)
        {
            if (userLoginField.Text == "")
                userLoginField.Text = "Login";
            userLoginField.ForeColor = Color.Gray;
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (userPasswordField.Text == "Login")
            {
                userPasswordField.Text = "";
                userPasswordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (userPasswordField.Text == "")
                userPasswordField.Text = "Password";
            userPasswordField.ForeColor = Color.Gray;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = Program.Services.GetRequiredService<RegisterForm>();
            registerForm.Show();

        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.FromArgb(1, 26, 39);
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.White;
        }

        public User TryGetByLogin(string login, string password)
        {
            if (db == null)
            {
                throw new InvalidOperationException("Database context is not initialized.");
            }
            return db.User.FirstOrDefault(x => x.Login == login && x.Password == password);

        }
        private void startButton_Click(object sender, EventArgs e)
        {
            var login = userLoginField.Text;
            var password = userPasswordField.Text;

            try
            {
                var existingUser = TryGetByLogin(login, password);

                if (existingUser != null)
                {
                    userFactory.ExistingUser = existingUser;
                    MessageBox.Show(userLoginField.Text + " , welcome to the game!");

                    this.Hide();
                    var chooseGameForm = Program.Services.GetRequiredService<ChooseGameForm>();
                    chooseGameForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FruitNinjaForm form = Program.Services.GetRequiredService<FruitNinjaForm>();
            form.Show();
        }
    }
}
