using System;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp
{
    public partial class QuestionsListForm : Form
    {
        public QuestionsListForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuestionsListForm_Load(object sender, EventArgs e)
        {
            //var questions = QuestionsRepository.GetAll();
            //foreach (var question in questions)
            //{
            //    questionsDataGridView.Rows.Add(question.Text, question.Answer);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var rows = questionsDataGridView.SelectedRows;

            //if (rows.Count == 0)
            //{
            //    MessageBox.Show("You should select the line that you would like to remove");
            //    return;
            //}
            //var questionText = rows[0].Cells[0].Value.ToString();

            //if (questionText != null)
            //{
            //    QuestionsRepository.Remove(questionText);
            //}
            //Close();
        }
    }
}
