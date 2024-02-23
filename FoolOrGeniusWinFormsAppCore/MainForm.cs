using System;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGenius.Db;
using FoolOrGeniusWinFormsApp.FoolOrGenius;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp
{
    public partial class MainForm : Form
    {
        UserFactory userFactory;
        GameService gameService;
        private int questionNumber = 0;
        private int countQuestions;

        DatabaseContext db;
        public MainForm(UserFactory userFactory, GameService gameService)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userFactory = userFactory;
            this.gameService = gameService;
            this.ControlBox = false;
            this.Text = "";
        }
        private void QuestionTextLabel_Click(object sender, EventArgs e)
        {
            questionTextLabel.AutoSize = false;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            gameService.StartNewGame();

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
                gameService.AcceptAnswer(userAnswer);

                if (gameService.End())
                {
                    var message = gameService.CalculateDiagnosis();
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
            UserAnswerTextBox.Text = "";
            var currentQuestion = gameService.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.QuestionText;

            questionNumberLabel.Text = gameService.GetQuestionNumberText();
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

        private void userResultsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            var resultsForm = Program.Services.GetRequiredService<DataGridViewFoolOrGeniusForm>();
            resultsForm.Show();
        }
    }
}
