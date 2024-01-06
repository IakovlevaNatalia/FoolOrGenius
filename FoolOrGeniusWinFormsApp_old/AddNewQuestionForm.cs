using System;
using System.Windows.Forms;
using FoolOrGeniusLibrary;
using System.ComponentModel; 

namespace FoolOrGeniusWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            

        }

        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewQuestionForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var parsed =
                InputValidator.TryParseToNumber(questionAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }

            var newQuestion = new Question(questionTextBox.Text, userAnswer);
            QuestionsRepository.Add(newQuestion);
            Close();
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
