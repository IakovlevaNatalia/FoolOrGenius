using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        //DatabaseContext db;
        public WelcomeForm()
        {
            InitializeComponent();
            //db = new DatabaseContext();

            userLogin.Text = "Login";
            userLogin.ForeColor = Color.Gray;

            passwordField.Text = "Password";
            passwordField.ForeColor = Color.Gray;

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(300, 60);
            this.userLogin.AutoSize = false;
            this.userLogin.Size = new Size(300, 60);

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void startButton_Click(object sender, EventArgs e)
        //{
        //    String userLogin2 = userLogin.Text;
        //    String userPassword = passwordField.Text;

        //    // DB db = new DB();

        //    //DataTable table = new DataTable();

        //    //MySqlDataAdapter adapter = new MySqlDataAdapter();


        //    //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`= @uP", db.getConnection());
        //    //command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userLogin;
        //    //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

        //    //adapter.SelectCommand = command;
        //    //adapter.Fill(table);

        //    //if (table.Rows.Count > 0)
        //    //    MessageBox.Show("Yes");
        //    //else
        //    //    MessageBox.Show("No");
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // exit from menuStrip
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) //restart restart menuStrip
        {
            Application.Restart();
        }

        private void showPreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void userLogin_Enter(object sender, EventArgs e)
        {

            if (userLogin.Text == "Login")
            {
                userLogin.Text = "";
                userLogin.ForeColor = Color.Black;
            }
        }

        private void userLogin_Leave(object sender, EventArgs e)
        {
            if (userLogin.Text == "")
                userLogin.Text = "Login";
            userLogin.ForeColor = Color.Gray;
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Login")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
                passwordField.Text = "Password";
            passwordField.ForeColor = Color.Gray;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = Program.Services.GetRequiredService<RegisterForm>();
            registerForm.Show();

        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Blue;
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.White;
        }
    }
}
