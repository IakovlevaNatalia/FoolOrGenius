using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class Ball
    {
       private Timer timer;
       protected Form form;
       protected float vx = 10; 
       protected float vy = 10;
       protected float centerX = 10;
       protected float centerY = 10;
       protected int radius = 25;

       Random random = new Random();

        public Ball(Form form)
        {
            this.form= form;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
           timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public virtual void Move()
        {
            ClearCatchMe();
            HandleEdgeCollision();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        protected virtual void HandleEdgeCollision()
        {

            if (centerX <= 0 || centerX + radius >= form.ClientSize.Width)
            {
                vx = -vx; 
            }

            if (centerY <= 0 || centerY + radius > form.ClientSize.Height)
            {
                vy = -vy; 
            }
        }
        public virtual void Show()
        {
            var brush = Brushes.DarkRed;
            Draw(brush);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void ClearCatchMe()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }
        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX<=RightSide() && centerY>=TopSide() && centerY<=DownSide();
        }

        public bool Contains(int pointX, int pointY)
        {

            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx*dx+dy*dy<=radius*radius;
        }

        public bool Intersect(Ball other)
        {
            var dx=centerX-other.centerX;
            var dy=centerY-other.centerY;
           return dx*dx+dy*dy<=(radius+other.radius)* (radius + other.radius);
        }
        protected virtual void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
