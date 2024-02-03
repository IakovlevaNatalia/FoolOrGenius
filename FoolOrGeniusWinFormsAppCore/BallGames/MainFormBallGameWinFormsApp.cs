using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public partial class MainFormBallGameWinFormsApp : Form
    {
        List< MoveBall> moveBalls;
        private PointBall pointBall;

        public MainFormBallGameWinFormsApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            //randomSizeAndPointBall.Show();
        }

        private void MainFormBallGameWinFormsApp_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
            }
        }

        private void ballsButton_Click(object sender, EventArgs e)
        {
            moveBalls= new List< MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }

        }
    }
}
