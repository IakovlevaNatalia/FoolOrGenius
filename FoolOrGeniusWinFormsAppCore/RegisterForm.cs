using FoolOrGenius.Db;
using FoolOrGenius.Db.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp
{
    public partial class RegisterForm : Form
    {
        DatabaseContext db;
        public RegisterForm(DatabaseContext db)
        {
            InitializeComponent();

            userFirstNameField.Text = "First name";
            userFirstNameField.ForeColor = Color.Gray;

            userLastNameField.Text = "Last name";
            userLastNameField.ForeColor = Color.Gray;

            userLoginField.Text = "Login";
            userLoginField.ForeColor = Color.Gray;

            userPasswordField.Text = "Password";
            userPasswordField.ForeColor = Color.Gray;

            userEmailField.Text = "E-mail";
            userEmailField.ForeColor = Color.Gray;

            this.db = db;

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void authorizationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorizationLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void authorizationLabel_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorizationLabel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void userFirstNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void userFirstNameField_Enter(object sender, EventArgs e)
        {
            if (userFirstNameField.Text == "First name")
            {
                userFirstNameField.Text = "";
                userFirstNameField.ForeColor = Color.Black;
            }
        }

        private void userFirstNameField_Leave(object sender, EventArgs e)
        {
            if (userFirstNameField.Text == "")
                userFirstNameField.Text = "First name";
            userFirstNameField.ForeColor = Color.Gray;
        }

        private void userLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userLastNameField_Enter(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "Last name")
                userLastNameField.Text = "";
            userLastNameField.ForeColor = Color.Black;
        }

        private void userLastNameField_Leave(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "")
                userLastNameField.Text = "Last name";
            userLastNameField.ForeColor = Color.Gray;

        }

        private void userLoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void userLoginField_Enter(object sender, EventArgs e)
        {
            if (userLoginField.Text == "Login")
                userLoginField.Text = "";
            userLoginField.ForeColor = Color.Black;
        }

        private void userLoginField_Leave(object sender, EventArgs e)
        {
            if (userLoginField.Text == "")
                userLoginField.Text = "Login";
            userLoginField.ForeColor = Color.Gray;
        }

        private void userPasswordField_Enter(object sender, EventArgs e)
        {
            if (userPasswordField.Text == "Password");
            userPasswordField.Text = "";
            userPasswordField.ForeColor = Color.Black;
        }

        private void userPasswordField_Leave(object sender, EventArgs e)
        {
            if (userPasswordField.Text == "");
            userPasswordField.ForeColor = Color.Gray;
        }

        private void userEmailField_Enter(object sender, EventArgs e)
        {
            if (userEmailField.Text == "E-mail") ;
            userEmailField.Text = "";
            userEmailField.ForeColor = Color.Black;
        }

        private void userEmailField_Leave(object sender, EventArgs e)
        {
            if (userEmailField.Text == "")
                userEmailField.Text = "E-mail";
            userEmailField.ForeColor = Color.Gray;
        }

        private void authorizathionLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }

        private void authorizathionLabel_MouseEnter(object sender, EventArgs e)
        {
            authorizathionLabel.ForeColor = Color.Blue;
        }

        private void authorizathionLabel_MouseLeave(object sender, EventArgs e)
        {
            authorizathionLabel.ForeColor = Color.White;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = userFirstNameField.Text;
            user.LastName = userLastNameField.Text;
            user.Email = userEmailField.Text;
            user.Login = userLoginField.Text;
            user.Password = userPasswordField.Text;
            user.RegistrationDate = DateTime.Now;
            db.User.Add(user);
            db.SaveChanges();
        }

        private void userPasswordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
