using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{
    public partial class FruitNinjaForm : Form
    {
        private static Random random = new Random();
        private Timer timer = new Timer();
        private List<FruitBall> fruits = new List<FruitBall>();
        private int caughtBallsCount = 0;


        private bool drawing;
        private List<Point> points;
        private Pen pen;

        private Timer bananaTimer = new Timer();
        private Timer slowdownTimer = new Timer();
       
        private bool isSlowedDown = false;
        private const int slowdownDuration = 5000; 
        private Brush brush;

        public FruitNinjaForm()
        {
            InitializeComponent();
            InitializeCustomCursor();
            InitializeDrawing();
            pen = new Pen(Color.DarkRed, 4);

            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;


            slowdownTimer.Interval = slowdownDuration;
            slowdownTimer.Tick += SlowdownTimer_Tick;
            this.ControlBox = false;
            this.Text = "";

        }
        private void InitializeDrawing()
        {
            drawing = false;
            points = new List<Point>();
            this.Paint += MainForm_Paint;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }

        private void InitializeCustomCursor()
        {
            Bitmap customImage = new Bitmap(Resources.sword, new Size(32, 32));
            Cursor customCursor = new Cursor(customImage.GetHicon());
            this.Cursor = customCursor;
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (!fruit.IsSliced)
                {
                    fruit.Draw(brush);
                }
            }
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                points.Add(e.Location);
                this.Invalidate();
            }
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = false;
                this.Invalidate();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            pen.Dispose();
        }
        private void FruitNinjaForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();

            bananaTimer.Interval = 12000; 
            bananaTimer.Tick += BananaTimer_Tick;
            bananaTimer.Start();

            CreateBalls(5);
        }

        private void CreateBananaBall()
        {
            BananaFruitBall bananaBall = new BananaFruitBall(this);
            fruits.Add(bananaBall);
            bananaBall.Start();
       }

        private void BananaTimer_Tick(object sender, EventArgs e)
        {
            BananaFruitBall bananaBall = fruits.OfType<BananaFruitBall>().FirstOrDefault();

            if (bananaBall == null)
            {
                CreateBananaBall();
            }
        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits.ToList())
            {
                if (fruit.IsMovable() && fruit.Contains(e.X, e.Y) && !fruit.IsSliced)
                {

                    if (fruit is BombaBall)
                    {
                        EndGame();
                        return;
                    }

                    fruit.Clear();
                    caughtBallsCount++;

                    if (caughtBallsCount == 2000)
                    {
                        Win();
                        fruit.Stop();
                    }

                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();

                    if (fruit is BananaFruitBall)
                    {
                        if (!isSlowedDown)
                        {
                            isSlowedDown = true;
                            slowdownTimer.Start();

                            foreach (var otherFruit in fruits.OfType<FruitBall>())
                            {
                                otherFruit.DecreaseVelocity();
                            }
                        }
                    }

                    fruit.SetSliced();
                    fruits.Remove(fruit);
                }
            }
        }
        private void Win()
        {

            MessageBox.Show("Congratulations! You caught all balls and won the game!");
        }
        private void EndGame()
        {
            timer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
            }

            MessageBox.Show("Game Over");
        }

        private void CreateBalls(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var fruit = new FruitBall(this);
                fruits.Add(fruit);
                fruit.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
           
            for (int i = 0; i < random.Next(4, 7); i++)
            {
                int randomNumber = random.Next(101);
                FruitBall fruitBall;

                if (randomNumber < 10)
                {
                    if (!fruits.Any(f => f is BananaFruitBall))
                    {
                        fruitBall = new BananaFruitBall(this);
                        fruits.Add(fruitBall);
                        fruitBall.Start();
                    }
                }
                else if (randomNumber < 10 + 5)
                {
                    fruitBall = new BombaBall(this);
                    fruits.Add(fruitBall);
                    fruitBall.Start();
                }
                else
                {
                    fruitBall = new FruitBall(this);
                    fruits.Add(fruitBall);
                    fruitBall.Start();
                }
            }

            timer.Interval = random.Next(2000, 5000);
        }
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Catch as many fruits as possible. Avoid the bomb, which is a black-colored sphere. The yellow ball slows down the movement of the balls and lowers them down. Score points. Good luck!");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to restart the game?", "Restart Game",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var fruitNinjaForm = Program.Services.GetRequiredService<FruitNinjaForm>();
                fruitNinjaForm.ShowDialog();
                this.Hide();
            }
        }

        private void FruitNinjaForm_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void SlowdownTimer_Tick(object sender, EventArgs e)
        {
            foreach (var fruit in fruits.OfType<FruitBall>())
            {
                fruit.RestoreSpeed();
            }

            isSlowedDown = false;
            slowdownTimer.Stop();
        }


    }
}