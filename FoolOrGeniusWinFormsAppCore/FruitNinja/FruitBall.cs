using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{
    public class FruitBall : RandomMoveBall

    {
        private float g = 0.2f;
        protected Brush brush;
        private float speed = 5.0f;
        private float originalVelocity;
        private Timer slowdownTimer = new Timer();
        private bool isSlowedDown = false;
        private const int slowdownDuration = 5000; // 5 секунд в миллисекундах


        public FruitBall(Form form) : base(form)
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            //radius = 20;
            radius = random.Next(10, 30);
            centerY = form.ClientSize.Height - radius;
            vy = (float)random.NextDouble() * -6 - 7;
            originalVelocity = (float)random.NextDouble() * -6 - 7;
           // decreaseVelosity = originalVelocity - 2.0f;

        }

        public override void Show()
        {
            Draw(brush);
        }
        protected override void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            if (centerY > DownSide() + 2 * radius)
            {
                Stop();
            }
        }

        public void DecreaseVelocity()
        {
            if (!isSlowedDown)
            {
                vy = 0.01f; // Уменьшаем вертикальную скорость
                vx = 0.01f; // Уменьшаем горизонтальную скорость

                isSlowedDown = true;

                slowdownTimer.Start();
            }
        }

        public void RestoreSpeed()
        {
            vy = (float)random.NextDouble() * -6 - 7;
            isSlowedDown =false;
        }

        public void SetSlowdown()
        {
            slowdownTimer.Start();
        }
    }
}