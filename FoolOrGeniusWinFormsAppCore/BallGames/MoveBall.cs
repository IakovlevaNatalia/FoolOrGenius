using System;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class MoveBall:RandomPointBall
    {
        private Timer timer;

        public MoveBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp) : base(mainFormBallGameWinFormsApp)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
