using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class TileResultsForm : Form
    {
        public TileResultsForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        private void TileResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
