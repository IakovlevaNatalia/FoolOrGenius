using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{
    public class FruitBall : RandomMoveBall

    {
        private float g = 0.2f;
        protected Brush brush;

        public FruitBall(Form form) : base(form)
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            radius = 20;
            centerY = form.ClientSize.Height - radius;
            vy = (float)random.NextDouble() * -6 - 7;
        }

        public override void Show()
        {
            Draw(brush);
        }
        protected override void Draw(Brush brush)
        {
            var graphics = catchMeForm.CreateGraphics();
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
    }
}