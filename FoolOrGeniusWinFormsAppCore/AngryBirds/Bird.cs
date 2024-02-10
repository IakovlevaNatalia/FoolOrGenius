using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public class Bird:RandomMoveBall
    {
        private float g = 0.2f; //сила тяжести
        private float elastic = 0.4f; //сила трения
        protected Brush brush;
        private PictureBox birdPictureBox;
        public Bird(Form form, PictureBox birdPictureBox) :base(form)
        {
            centerX = LeftSide(); // начальное положение птицы
            centerY = DownSide();

            //var centerX = pictureBox.Location.X + pictureBox.Width / 2;
            //var centerY = pictureBox.Location.Y + pictureBox.Height / 2;

            this.birdPictureBox= birdPictureBox;
            //brush = Brushes.DarkOrange;
        }
        protected override void Go()
        {
            base.Go();


            if (centerY > DownSide()) //если столкнулись с нижней стенкой
            {
                vy = -vy;
                centerY= DownSide();
                vy = vy * elastic;
                vx = vx * elastic;
            }

            if (vy < 0.1 && vx < 0.1)
            {
                Stop();
            }
            vy += g;
            
        }
        public bool IsOutSide()
        {
            return centerX > RightSide();
        }
        public void SetVelocity(int x, int y)
        {
            vx=(x-centerX)/20;
            vy=(y-centerY)/20;
        }
        //public override void Show()
        //{
        //    Draw(brush);
        //}

        public override void Show()
        {
            if (birdPictureBox != null)
            {
                // Вместо рисования кисточкой используем PictureBox
                birdPictureBox.Location = new Point((int)(centerX - birdPictureBox.Width / 2), (int)(centerY - birdPictureBox.Height / 2));
            }
        }

    }
}
