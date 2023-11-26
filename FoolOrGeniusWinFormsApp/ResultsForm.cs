using System;
using FoolOrGeniusLibrary;
using System.Windows.Forms;


namespace FoolOrGeniusWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsRepository.GetUserResults();

            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnose);
            }
        }
    }
}
