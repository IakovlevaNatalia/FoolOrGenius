using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FoolOrGeniusLibrary;

namespace FoolOrGeniusWinFormsApp
{
    public partial class mainForm : Form
    {
       Game game;

        public mainForm()
        {
            InitializeComponent();
        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm=new WelcomeForm();
            welcomeForm.ShowDialog();

            var user = new User(welcomeForm.userName.Text);
            game = new Game(user);

            ShowNextQuestion();
        }
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
    }
}
