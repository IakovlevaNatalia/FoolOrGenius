using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{

    public partial class FruitNinjaForm : Form
    {
        private static Random random = new Random();
        private Timer timer = new Timer();
        private List<FruitBall> fruits = new List<FruitBall>();
        private int caughtBallsCount = 0;

        public FruitNinjaForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FruitNinjaForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();

            CreateBalls(5);
        }
       
        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.IsMovable() && fruit.Contains(e.X, e.Y))
                {
                    fruit.Stop();

                    if (fruit is BombaBall)
                    {
                        EndGame();
                        return;
                    }

                    fruit.ClearCatchMe();
                    caughtBallsCount++;

                    if (caughtBallsCount == 20)
                    {
                        Win();
                        fruit.Stop();
                    }
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
                }
            }
        }

        private void Win()
        {
            
            MessageBox.Show("Congratulations! You caught all balls and won the game!");
        }
        private void EndGame()
        {
            timer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
            }

            MessageBox.Show("Game Over");
        }

        private void CreateBalls(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var fruit = new FruitBall(this);
                fruits.Add(fruit);
                fruit.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var bombNumber = random.Next(5);
                var ball = bombNumber == 4 ? new BombaBall(this) : new FruitBall(this);
                fruits.Add(ball);
                ball.Start();
            }

            timer.Interval = random.Next(2000, 5000);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Catch as many fruits as possible. Avoid the bomb, which is a black-colored sphere. Score points. Good luck!");
        }
    }
}