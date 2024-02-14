using System;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.Firework
{
    public partial class FireworkForm : Form
    {
        private static Random random = new Random();
        public FireworkForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FireworkForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ball = new FireworkBall(this, e.X, e.Y);
                ball.Start();
            }
        }
        private void Ball_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ball = new FireworkBall(this, e.X, e.Y);
                ball.Start();
            }
        }
        private void fireworksStartButton_Click_1(object sender, EventArgs e)
        {
            var ball = new StartFireworksBall(this);
            ball.TopReached += Ball_TopReached;
            ball.Start();
        }

    }
}
