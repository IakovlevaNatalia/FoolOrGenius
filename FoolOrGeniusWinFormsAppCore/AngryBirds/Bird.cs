using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public class Bird:RandomMoveBall
    {
        private float g = 0.2f; 
        private float elastic = 0.4f; 
        private PictureBox birdPictureBox;
        public Bird(Form form, PictureBox birdPictureBox) :base(form)
        {
            centerX = LeftSide(); 
            centerY = DownSide();

            this.birdPictureBox= birdPictureBox;
        }

        public override void Move()
        {
            HandleEdgeCollision();
            Go();
            Show();
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

        public override void Show()
        {
            if (birdPictureBox != null)
            {
                birdPictureBox.Location = new Point((int)(centerX - birdPictureBox.Width / 2), (int)(centerY - birdPictureBox.Height / 2));
            }
        }
        public bool IntersectWithPig(PictureBox pigPictureBox)
        {

            Rectangle thisBounds = new Rectangle((int)centerX - birdPictureBox.Width / 2, (int)centerY - birdPictureBox.Height / 2, birdPictureBox.Width, birdPictureBox.Height);
            Rectangle otherBounds = new Rectangle(pigPictureBox.Location, pigPictureBox.Size);

            return thisBounds.IntersectsWith(otherBounds);
        }
    }
}
