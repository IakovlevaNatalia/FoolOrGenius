using System;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.Firework
{
    public class FireworkBall:RandomMoveBall
    {
        private float g = 0.2f;
        private float x;
        private float y;

        public FireworkBall (Form form, float centerX, float centerY) : base(form)
        {
            radius = 15;
            this.centerX=centerX;
            this.centerY=centerY;
            vy = -Math.Abs(vy);
        }

        public Action<object, TopReachedEventArgs> TopReached { get; internal set; }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        protected override void HandleEdgeCollision()
        {

        }
      
    }
}
