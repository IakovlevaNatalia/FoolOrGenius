using FoolOrGeniusWinFormsApp.BallGames;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.CatchMe
{
    public partial class CatchMeMainForm : Form
    {
        private List<Ball> balls;
        private int countBalls = 0;
        
        public CatchMeMainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            clearButton.Enabled = true;
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();

                var ball = new RandomSizeAndPointBall(this);
                balls.Add(ball);
                ball.Start();

            }
        }
        private void CatchMeMainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void CatchMeMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls != null)
            {
                foreach (var ball in balls)
                {
                    if (ball.IsMovable() && ball.Contains(e.X, e.Y))
                    {
                        ball.Stop();
                        countBalls++;
                    }
                }

                ballsCountLabel.Text = countBalls.ToString();
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true;

            Invalidate();
        }
        private void FinishGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
