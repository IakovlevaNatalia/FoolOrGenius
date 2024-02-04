using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public partial class MainFormBallGameWinFormsApp : Form
    {
        List<RandomMoveBall> moveBalls;
        private PointBall pointBall;

        public MainFormBallGameWinFormsApp()
        {
            InitializeComponent();
        }

        private void MainFormBallGameWinFormsApp_MouseDown(object sender, MouseEventArgs e)
        {
            //pointBall = new PointBall(this, e.X, e.Y);
            //pointBall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                if (ball.OnForm())
                {
                    countBalls++;
                }
            }

            MessageBox.Show(countBalls.ToString());
            stopButton.Enabled= false;
            clearButton.Enabled = true;
        }

        //private void ballsButton_Click(object sender, EventArgs e)
        //{
        //    stopButton.Enabled = true;
        //    startButton.Enabled = false;

        //    moveBalls = new List<RandomMoveBall>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        var moveBall = new RandomMoveBall(this);
        //        moveBalls.Add(moveBall);
        //        moveBall.Start();
        //    }

        //}

        private void MainFormBallGameWinFormsApp_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.ClearCatchMe();
            }

            clearButton.Enabled = false;
            startButton.Enabled=true;
        }
    }
}
