using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public partial class MainFormBallGameWinFormsApp : Form
    {
        private RandomSizeAndPointBall randomSizeAndPointBall;
        private PointBall pointBall;

        public MainFormBallGameWinFormsApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                randomSizeAndPointBall.Move();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            randomSizeAndPointBall.Show();
        }

        private void MainFormBallGameWinFormsApp_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pointBall.Move();

        }
    }
}
