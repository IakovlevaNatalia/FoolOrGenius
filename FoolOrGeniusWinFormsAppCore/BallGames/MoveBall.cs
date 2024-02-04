using System;
using System.Windows.Forms;
using System.Threading;
using FoolOrGeniusWinFormsApp.CatchMe;
using Timer = System.Windows.Forms.Timer;
using System.Collections.Generic;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class MoveBall:RandomPointBall
    {
        private Timer timer;

        public MoveBall(Form mainFormBallGameWinFormsApp) : base(mainFormBallGameWinFormsApp)
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

        public bool IsMovable()
        {
            return timer.Enabled;
        }

    }
}
