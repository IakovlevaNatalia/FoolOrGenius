using FoolOrGeniusWinFormsApp._2048_Game;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.FoolOrGenius
{
    public partial class FoolOrGeniusRulesAndResults : Form
    {
        public FoolOrGeniusRulesAndResults()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new Size(726, 748);
            this.ControlBox = false;
            this.Text = "";
        }

        private void userResultsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var resultsForm = Program.Services.GetRequiredService<DataGridViewFoolOrGeniusForm>();
            resultsForm.Show();
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var mainForm = Program.Services.GetRequiredService<MainForm>();
            mainForm.ShowDialog();
        }
    }
}
