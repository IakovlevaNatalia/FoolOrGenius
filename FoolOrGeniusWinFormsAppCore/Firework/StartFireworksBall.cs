using System;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.Firework
{
    public class StartFireworksBall:FireworkBall
    {
        public event EventHandler<TopReachedEventArgs> TopReached;

        public StartFireworksBall(Form form):base(form, form.ClientSize.Width/2, form.ClientSize.Height)
        {
            vy = (float)random.NextDouble() * -6 - 7;
            vx = 0;
        }

        protected override void Go()
        {
            base.Go();
            if (vy > 0)
            {
                Stop();
                ClearCatchMe();
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
        }
    }
}
