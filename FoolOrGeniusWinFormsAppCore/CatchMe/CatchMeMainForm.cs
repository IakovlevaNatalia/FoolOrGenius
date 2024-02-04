using FoolOrGeniusWinFormsApp.BallGames;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.CatchMe
{
    public partial class CatchMeMainForm : Form
    {
        private List<RandomMoveBall> moveBalls;
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
            moveBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 12; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void CatchMeMainForm_Load(object sender, EventArgs e)
        {
            //MoveBall ball1 = new MoveBall(this); 
            //MoveBall ball2 = new MoveBall(this);

            //List<MoveBall> balls = new List<MoveBall> { ball1, ball2 };
            //Timer timer = new Timer();
            //timer.Interval = 20;
            //timer.Tick += (timerSender, timerEventArgs) =>
            //{
            //    foreach (var ball in balls)
            //    {
            //        ball.Timer_Tick(timerSender, timerEventArgs);
            //    }
            //};

            //timer.Start();
            clearButton.Enabled = false;
        }

        private void CatchMeMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
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
            foreach (var ball in moveBalls)
            {
                ball.ClearCatchMe();
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
