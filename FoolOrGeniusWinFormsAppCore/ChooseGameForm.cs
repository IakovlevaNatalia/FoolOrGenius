using System;
using System.Windows.Forms;
using FoolOrGenius.Db;
using FoolOrGeniusWinFormsApp._2048_Game;
using FoolOrGeniusWinFormsApp.BallGames;
using FoolOrGeniusWinFormsApp.CatchMe;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp
{
    public partial class ChooseGameForm : Form
    {
        UserFactory userFactory;
        GameService gameService;
        private DatabaseContext db;
        public ChooseGameForm(DatabaseContext db, GameService gameService)
        {
            InitializeComponent();
            this.db = db;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gameService = gameService;
        }

        private void ChooseGame_Load(object sender, EventArgs e)
        {

        }

        private void TwentyFortyEightGameLabel_Click(object sender, EventArgs e)
        {
            ChooseSizeForm chooseSizeForm = new ChooseSizeForm();
            chooseSizeForm.ShowDialog();
            this.Hide();

        }

        private void FoolOrGeniusLabel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (foolOrGeniusRadioButton.Checked)
            {
                this.Hide();
                var mainForm = Program.Services.GetRequiredService<mainForm>();
                mainForm.ShowDialog();
            }

            if (Game2048RadioButton.Checked)
            {
                this.Hide();
                ChooseSizeForm chooseSizeForm = new ChooseSizeForm();
                chooseSizeForm.ShowDialog();
            }

            if (easyBallRadioButton.Checked)
            {
                this.Hide();
                var catchMeForm = Program.Services.GetRequiredService<CatchMeMainForm>();
                catchMeForm.ShowDialog();
            }
        }

    }
}
