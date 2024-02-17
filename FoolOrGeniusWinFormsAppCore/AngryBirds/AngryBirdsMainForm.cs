using System;
using System.Drawing;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public partial class AngryBirdsMainForm : Form
    {
        private Bird bird;
        private Piggy piggy;
        private PictureBox birdPictureBox;
        private PictureBox pigPictureBox;
        private int collision = 0;

        Timer timer = new Timer();

        public AngryBirdsMainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(816, 458);

            PictureBox backgroundPictureBox = new PictureBox();
            backgroundPictureBox.Size = this.ClientSize;
            backgroundPictureBox.Location = new Point(0, 0);
            backgroundPictureBox.Image = Resources.background;
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.SendToBack();
            backgroundPictureBox.Parent = this;
            backgroundPictureBox.MouseDown += AngryBirdsMainForm_MouseDown;

            birdPictureBox = new PictureBox();
            birdPictureBox.Size = new Size(60, 60);
            birdPictureBox.BackColor = Color.Transparent;
            birdPictureBox.Image = Resources.whiteBird;
            birdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            birdPictureBox.Location = new Point(0, this.ClientSize.Height - birdPictureBox.Height);
            birdPictureBox.Parent = backgroundPictureBox;


            pigPictureBox = new PictureBox();
            pigPictureBox.Size = new Size(60, 60);
            pigPictureBox.BackColor = Color.Transparent;
            pigPictureBox.Image = Resources.pig;
            pigPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pigPictureBox.Parent = backgroundPictureBox;


            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Parent = backgroundPictureBox;
            ScoreLabel.ForeColor = Color.FromArgb(32, 92, 8);
            ScoreLabel.Font = new Font(ScoreLabel.Font.FontFamily, 16, FontStyle.Bold);
            ScoreLabel.BackColor = Color.Transparent;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (bird.IntersectWithPig(pigPictureBox))
            {
                collision++;
                ScoreLabel.Text = $"Score :{collision}";
                CreateNewBird();
                CreateNewPig();
            }
            if (!bird.IsMovable())
            {
                CreateNewBird();
            }

            if (bird.IsOutSide())
            {
                CreateNewBird();
            }
        }
        private void AngryBirdsMainForm_Shown(object sender, EventArgs e)
        {
            this.ScoreLabel.Text = "0";

            CreateNewBird();
            CreateNewPig();
        }

        private void CreateNewPig()
        {
            if (piggy != null)
            {
                piggy.Clear();
            }
            piggy = new Piggy(this, pigPictureBox);
            piggy.Show();
        }

        void CreateNewBird()
        {
            timer.Stop();

            if (bird != null)
            {
                bird.Stop();
            }
            bird = new Bird(this, birdPictureBox);
            bird.Show();

        }
        private void AngryBirdsMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bird.SetVelocity(e.X, e.Y);
            timer.Start();
            bird.Start();

        }

    }
}
