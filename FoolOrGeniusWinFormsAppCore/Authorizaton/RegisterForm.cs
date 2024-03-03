using FoolOrGenius.Db;
using FoolOrGenius.Db.Models;
using System.Text.RegularExpressions;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

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
            if (userPasswordField.Text == "Password")
            userPasswordField.Text = "";
            userPasswordField.ForeColor = Color.Black;
        }

        private void userPasswordField_Leave(object sender, EventArgs e)
        {
            if (userPasswordField.Text == "")
            userPasswordField.ForeColor = Color.Gray;
        }

        private void userEmailField_Enter(object sender, EventArgs e)
        {
            if (userEmailField.Text == "E-mail") 
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
            var welcomeForm = Program.Services.GetRequiredService<WelcomeForm>();
            welcomeForm.ShowDialog();
        }

        private void authorizathionLabel_MouseEnter(object sender, EventArgs e)
        {
            authorizathionLabel.ForeColor = Color.Blue;
        }

        private void authorizathionLabel_MouseLeave(object sender, EventArgs e)
        {
            authorizathionLabel.ForeColor = Color.White;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            if (name.Length < 2 || name.Length > 20)
            {
                return false;
            }
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidLogin (string login)
        {
            if(string.IsNullOrWhiteSpace(login))
            {
                return false;
            }

            if (login.Length < 2 || login.Length > 20)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(string password)
        {
            if(string.IsNullOrEmpty(password))
            {
                return false;
            }

            if(password.Length<2 || password.Length > 20)
            {
                return false;
            }
            return true;
        }

        public bool CheckUserLoginExist(string login)
        {
            bool userExist = db.User.Any(x => x.Login == login);
            return userExist;
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (!IsValidName(userFirstNameField.Text) || userFirstNameField.Text == "First name") 
            {
                FirstNameErrorProvider.SetError(userFirstNameField, "It is a required field");
                MessageBox.Show("Please provide your first name. The name must contain only letters, be a minimum of two characters, and have a maximum length of 20 characters.");
                ok = false;
            }

            if (ok && !IsValidName(userLastNameField.Text) || userLastNameField.Text == "Last name")
            {
                LastNameErrorProvider.SetError(userLastNameField, "Please provide your last name. It is a required field");
                MessageBox.Show("Please provide your last name. The last name must contain only letters, be a minimum of two characters, and have a maximum length of 20 characters.");
                ok = false;
            }

            if (ok && !IsValidLogin(userLoginField.Text) || userLoginField.Text == "Login")
            {
                loginErrorProvider.SetError(userLoginField, "Please provide your login. It is a required field");
                MessageBox.Show("Please provide your login. The login must be a minimum of two characters, and have a maximum length of 20 characters.");
                ok = false;

            }
            if (ok && !IsValidEmail(userEmailField.Text) || userEmailField.Text=="E-mail")

            {
                emailErrorProvider.SetError(userEmailField, "Please provide your e-mail. It is a required field.");
                MessageBox.Show("Please provide your e-mail.");
                ok = false;

            }
            if (ok && !IsValidPassword(userPasswordField.Text) ||(userPasswordField.Text=="Password"))
            {
                passwordErrorProvider.SetError(userPasswordField, "Please provide your password. It is a required field");
                MessageBox.Show("Please provide you password. The password must be a minimum of two characters, and have a maximum length of 20 characters.");
                ok = false;
            }

            if(ok && CheckUserLoginExist(userLoginField.Text))
            {
                MessageBox.Show("A user with this login already exists in our system. Please create unique login.");
                ok = false;
            }

            if (ok)
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
                    MessageBox.Show(userFirstNameField.Text + ", you have successfully registered!");
                    this.Hide();

                var welcomeForm = Program.Services.GetRequiredService<WelcomeForm>();
                welcomeForm.ShowDialog();

            }
        }
    }
}
