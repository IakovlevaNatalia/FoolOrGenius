using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FoolOrGeniusLibrary;

namespace FoolOrGeniusWinFormsApp
{
    public partial class mainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int countQuestions;
        private int questionNumber=0;
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
            questions = QuestionsRepository.GetAll();
            countQuestions = questions.Count;
            user = new User("Неизвестно");
            questionNumber = 0;
            ShowNextQuestion();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(UserAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
            questions.Remove(currentQuestion);

            var endGame = questions.Count == 0;

            if (endGame)
            {
                user.Diagnose= DiagnoseCalculator.Calculate(countQuestions, user);
                MessageBox.Show(user.Diagnose);
                return;
            }
            ShowNextQuestion();
        }
        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questionTextLabel.Text = currentQuestion.Text;

            questionNumber++;
            questionNumberLabel.Text= "Question №" +questionNumber;

        }
    }
}
