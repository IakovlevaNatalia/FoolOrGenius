using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{
    public class FruitBall : RandomMoveBall
    {
        private float g = 0.2f;
        protected Brush brush;
        private Graphics graphics;
        private bool isSlowedDown = false;
        public bool IsSliced { get; set; }
        public FruitBall(Form form) : base(form)
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            radius = random.Next(10, 35);
            centerY = form.ClientSize.Height - radius;
            vy = (float)random.NextDouble() * -6 - 7;

            graphics = form.CreateGraphics();
        }

        public override void Show()
        {
            Draw(brush);
        }

        public override void Clear()
        {
            if (IsSliced)
            {
                var whiteBrush = Brushes.White;
                DrawSliced(whiteBrush);
            }
            else
            {
                base.Clear();
            }
        }

        public override void Draw(Brush brush)
        {
            if (brush == null)
            {
                return;
            }

            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            if (IsSliced)
            {
                DrawSliced(brush);
            }
            else
            {
                graphics.FillEllipse(brush, rectangle);
            }
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
                vy = 0.01f; 
                vx = 0.01f; 

                isSlowedDown = true;

            }
        }
        public void RestoreSpeed()
        {
            vy = (float)random.NextDouble() * -6 - 7;
            isSlowedDown =false;
        }

        private void DrawSliced(Brush brush)
        {
            var sliceWidth = 10; 
            var lineWidth = 10;

           var firstHalf = new Rectangle((int)centerX - radius - sliceWidth / 2, (int)centerY - radius, radius + sliceWidth / 2, radius * 2);
            graphics.FillPie(brush, firstHalf, (float)45, 180);

           var secondHalf = new Rectangle((int)centerX - radius + sliceWidth / 2, (int)centerY - radius, radius + sliceWidth / 2, radius * 2);
            graphics.FillPie(brush, secondHalf, 225, 180);

            var linePen = new Pen(Color.Transparent, lineWidth);
            graphics.DrawLine(linePen, (int)centerX - radius - sliceWidth / 2, (int)centerY, (int)centerX + radius + sliceWidth / 2, (int)centerY);
        }

        public void SetSliced()
        {
            IsSliced = true;

            vx = 0f;
            vy = 1f;

        }

        public override void Move()
        {
            base.Move();

            vy += g;
        }

        protected override void HandleEdgeCollision()
        {
            if (IsSliced)
            {
                if (centerY <= 0 || centerY + radius > form.ClientSize.Height)
                {
                    Stop();

                    brush = Brushes.White;
                }
            }
            else
            {
                base.HandleEdgeCollision();
            }
        }
    }
}