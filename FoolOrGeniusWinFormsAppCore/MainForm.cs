using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp
{
    public partial class mainForm : Form
    {
        Game game;

        public mainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionTextLabel_Click(object sender, EventArgs e)
        {
            questionTextLabel.AutoSize = false;
        }

        //private User GetAuthenticatedUser()
        //{
        //    //return User..GetUserByLogin("exampleUser");
        //}
        private void mainForm_Load(object sender, EventArgs e)
        {
            //var welcomeForm = Program.Services.GetRequiredService<WelcomeForm>();
            //welcomeForm.ShowDialog();

            //var user = new User(welcomeForm.userLoginField.Text);
            //game = new Game(user);

            //ShowNextQuestion();
            
            var userLogin = "exampleUser";
            var user = new User(userLogin);

            game = new Game(user);

            ShowNextQuestion();
        }

        //private User GetAuthenticatedUser()
        //{
        //    // Здесь вы должны предоставить код для получения информации о авторизованном пользователе
        //    // Например, если у вас есть сервис для работы с пользователями, используйте его
        //    // Замените следующую строку кода на свой метод получения пользователя
        //    return UserService.GetUserByLogin("exampleUser");
        //}
        private void nextbutton_Click(object sender, EventArgs e)
        {
            var parsed =
                InputValidator.TryParseToNumber(UserAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);

                if (game.End())
                {
                    var message = game.CalculateDiagnose();
                    MessageBox.Show(message);
                }
                else
                {
                    ShowNextQuestion();
                }
            }
        }
        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;

            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextbutton_MouseEnter(object sender, EventArgs e)
        {
            nextbutton.ForeColor = Color.Blue;

        }

        private void nextbutton_MouseLeave(object sender, EventArgs e)
        {
            nextbutton.ForeColor = Color.White;
        }
      
    }
}
