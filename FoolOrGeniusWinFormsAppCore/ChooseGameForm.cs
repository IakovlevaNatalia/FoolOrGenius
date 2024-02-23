using System;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp._2048_Game;
using FoolOrGeniusWinFormsApp.AngryBirds;
using FoolOrGeniusWinFormsApp.CatchMe;
using FoolOrGeniusWinFormsApp.Frog;
using FoolOrGeniusWinFormsApp.FruitNinja;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp
{
    public partial class ChooseGameForm : Form
    {
        public ChooseGameForm()
        {
            InitializeComponent();

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
        private void TwentyFortyEightGameLabel_Click(object sender, EventArgs e)
        {
            ChooseSizeForm chooseSizeForm = new ChooseSizeForm();
            chooseSizeForm.ShowDialog();
            this.Hide();

        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (foolOrGeniusRadioButton.Checked)
            {
                this.Hide();
                var form = Program.Services.GetRequiredService<MainForm>();
                form.ShowDialog();
            }

            if (Game2048RadioButton.Checked)
            {
                this.Hide();
                var form = Program.Services.GetRequiredService<ChooseSizeForm>();
                form.ShowDialog();
            }

            if (easyBallRadioButton.Checked)
            {
                this.Hide();
                var form = Program.Services.GetRequiredService<CatchMeMainForm>();
                form.ShowDialog();
            }

            if (FruitNinjaRadioButton.Checked)
            {
                this.Hide();
                var form= Program.Services.GetRequiredService<FruitNinjaForm>();
                form.ShowDialog();
            }

            if (angryBirdsRadioButton.Checked)
            {
                this.Hide();
                var form= Program.Services.GetRequiredService<AngryBirdsMainForm>();
                form.ShowDialog();
            }

            if (FrogRadioButton.Checked)
            {
                this.Hide();
                var frogGame = Program.Services.GetRequiredService<FrogMainForm>();
                frogGame.ShowDialog();
            }
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
