using System;
using System.Drawing;
using System.Linq;
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
        public string GetDiagnosis(int countQuestions, int countRightAnswers)
        {
            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            var diagnosisId = CalculateDiagnosis(percentRightAnswers);

            var diagnosisName = GetDiagnosisName(diagnosisId);

            return diagnosisName;
        }

        private int CalculateDiagnosis(int percentRightAnswers)
        {

            return (percentRightAnswers / 20) + 1;
        }

        private string GetDiagnosisName(int diagnosisId)
        {
            var diagnosis = db.Diagnosis.FirstOrDefault(d => d.Id == diagnosisId);

            return diagnosis?.DiagnosisName;
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
        //private void userResultsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var userResultsForm = Program.Services.GetRequiredService<DataGridViewFoolOrGeniusForm>();
        //    userResultsForm.Show();

        //}
    }
}
