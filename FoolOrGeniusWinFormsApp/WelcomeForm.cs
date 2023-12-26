using System;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
    }
}
