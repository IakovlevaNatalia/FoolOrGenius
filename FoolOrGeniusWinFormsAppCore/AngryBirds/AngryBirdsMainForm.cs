using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.Controls;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public partial class AngryBirdsMainForm : Form
    {
        private Bird bird;
        private Piggy piggy;
        private PictureBox birdPictureBox;
        //private Point birdStartCenterPosition = new Point(70, 374);
        //private PointF birdStartPosition = new Point(0, 0);

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
            backgroundPictureBox.Image = Resources.background; // Замените на свой ресурс фона
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.SendToBack(); // Поместите фон за птицу

            // Создание и настройка PictureBox
            var birdPictureBox = new PictureBox();
            
            birdPictureBox.Size = new Size(60, 60); // Установите размеры ваших требований
            birdPictureBox.BackColor = Color.Transparent; // Используйте Color.Transparent для прозрачного фона

            birdPictureBox.Image = Resources.whiteBird;
            birdPictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
            // Установка координат в левый нижний угол формы
            birdPictureBox.Location = new Point(0, this.ClientSize.Height - birdPictureBox.Height);

            birdPictureBox.Parent = backgroundPictureBox;
            // Добавление PictureBox на форму
            //this.Controls.Add(birdPictureBox);

            var pigPictureBox = new PictureBox();

            pigPictureBox.Size = new Size(60, 60); // Установите размеры ваших требований
            pigPictureBox.BackColor = Color.Transparent; // Используйте Color.Transparent для прозрачного фона

            pigPictureBox.Image = Resources.pig;
            pigPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // Установка координат в левый нижний угол формы
           // pigPictureBox.Location = new Point(30, this.ClientSize.Height - birdPictureBox.Height);

            ScoreLabel.BackColor=Color.Transparent;
            pigPictureBox.Parent = backgroundPictureBox;

            ScoreLabel.Parent = backgroundPictureBox;
            ScoreLabel.ForeColor = Color.FromArgb(32, 92, 8);
            ScoreLabel.Font = new Font(ScoreLabel.Font, FontStyle.Bold);
            ScoreLabel.BackColor = Color.Transparent;

            this.Controls.Add(backgroundPictureBox);

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
            bird = new Bird(this, birdPictureBox);
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
