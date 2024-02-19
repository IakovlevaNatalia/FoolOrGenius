using System;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGenius.Db;
using FoolOrGeniusWinFormsApp._2048_Game;
using FoolOrGeniusWinFormsApp.AngryBirds;
using FoolOrGeniusWinFormsApp.CatchMe;
using FoolOrGeniusWinFormsApp.Firework;
using FoolOrGeniusWinFormsApp.Frog;
using FoolOrGeniusWinFormsApp.FruitNinja;
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

            this.gameService = gameService;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(726, 748);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.startButton.Location = new Point(269, 514);
            this.chooseGameLabel.Text = "Сhoose your favorite game";
            this.chooseGameLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.ControlBox = false;
            this.Text = "";
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

            if (FireworkRadioButton.Checked)
            {
                this.Hide();
                var firework = Program.Services.GetRequiredService<FireworkForm>();
                firework.ShowDialog();
            }

            if (FruitNinjaRadioButton.Checked)
            {
                this.Hide();
                var fruitNinja = Program.Services.GetRequiredService<FruitNinjaForm>();
                fruitNinja.ShowDialog();
            }

            if (angryBirdsRadioButton.Checked)
            {
                this.Hide();
                var angryBirds = Program.Services.GetRequiredService<AngryBirdsMainForm>();
                angryBirds.ShowDialog();
            }

            if (FrogRadioButton.Checked)
            {
                this.Hide();
                var frogGame = Program.Services.GetRequiredService<FrogMainForm>();
                frogGame.ShowDialog();
            }
        }

        private void authorizationLabel_Click(object sender, EventArgs e)
        {

        }

        private void chooseGamepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseGameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.Blue;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.White;
        }
    }
}
