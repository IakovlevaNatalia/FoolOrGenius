﻿using System;
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
            this.ControlBox = false;
            this.Text = "";
        }

        private void MainFormBallGameWinFormsApp_MouseDown(object sender, MouseEventArgs e)
        {

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
            MessageBox.Show("You catch + countBalls + balls");
            stopButton.Enabled = false;
            clearButton.Enabled = true;
        }

        private void MainFormBallGameWinFormsApp_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }

            clearButton.Enabled = false;
            startButton.Enabled=true;
        }
    }
}
