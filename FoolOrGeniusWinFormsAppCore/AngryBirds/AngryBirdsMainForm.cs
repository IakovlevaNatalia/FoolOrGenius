using System;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public partial class AngryBirdsMainForm : Form
    {
        private Bird bird;
        private Piggy piggy;
        Timer timer = new Timer();
        public AngryBirdsMainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (bird.Intersect(piggy))
            {
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
                piggy.ClearCatchMe();
            }
            piggy = new Piggy(this);
            piggy.Show();
        }

        void CreateNewBird()
        {
            timer.Stop();

            if (bird != null)
            {
                bird.Stop();
                bird.ClearCatchMe();
            }
            bird = new Bird(this);
            bird.Show();
        }

        private void AngryBirdsMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bird.SetVelocity(e.X, e.Y);
            timer.Start();
            bird.Start();
           
        }

        private void AngryBirdsMainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
