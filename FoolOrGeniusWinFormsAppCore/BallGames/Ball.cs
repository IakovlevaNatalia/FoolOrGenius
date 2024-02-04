using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.CatchMe;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class Ball
    {
       private Form mainFormBallGameWinFormsApp;
       private Form catchMeForm;
       protected int vx = 5; 
       protected int vy = -5;
       protected int x = 150;
       protected int y = 150;
       protected int size = 50;
       protected static Random random = new Random();

        public Ball(Form mainFormBallGameWinFormsApp)
        {
            this.mainFormBallGameWinFormsApp= mainFormBallGameWinFormsApp;
        }
        public void Move(RandomMoveBall ball1, RandomMoveBall ball2, List<RandomMoveBall> balls)
        {
            Clear();
            HandleEdgeCollision();
            HandleBallBounce(ball1, ball2);
            HandleBallCollision(balls);
            Go();
            Show();
        }

        private void HandleEdgeCollision()
        {
            var catchMeForm = Program.Services.GetRequiredService<CatchMeMainForm>();

            if (x <= 0 || x + size >= catchMeForm.ClientSize.Width)
            {
                vx = -vx; 
            }

            if (y <= 0 || y + size >= catchMeForm.ClientSize.Height)
            {
                vy = -vy; 
            }
        }
        private void HandleBallCollision(List<RandomMoveBall> balls)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                for (int j = i + 1; j < balls.Count; j++)
                {
                    if (balls[i].Intersects(balls[j]))
                    {
                        HandleBallBounce(balls[i], balls[j]);
                    }
                }
            }
        }
        private void HandleBallBounce(RandomMoveBall ball1, RandomMoveBall ball2)
        {
            double angle = Math.Atan2(ball2.y - ball1.y, ball2.x - ball1.x);
            double magnitude1 = Math.Sqrt(ball1.vx * ball1.vx + ball1.vy * ball1.vy);
            double magnitude2 = Math.Sqrt(ball2.vx * ball2.vx + ball2.vy * ball2.vy);

            double newVx1 = magnitude2 * Math.Cos(angle);
            double newVy1 = magnitude2 * Math.Sin(angle);
            double newVx2 = magnitude1 * Math.Cos(angle);
            double newVy2 = magnitude1 * Math.Sin(angle);

            ball1.vx = (int)newVx1;
            ball1.vy = (int)newVy1;
            ball2.vx = (int)newVx2;
            ball2.vy = (int)newVy2;
        }
        public bool Intersects(RandomMoveBall otherBall)
        {
            double distance = Math.Sqrt(Math.Pow(otherBall.x - x, 2) + Math.Pow(otherBall.y - y, 2));
            double sumRadii = size/ 2.0 + otherBall.size / 2.0;

            return distance < sumRadii;
        }


        public void Show()
        {
            var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }

        public void Clear()
        {
            var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
            var brush = new SolidBrush(mainFormBallGameWinFormsApp.BackColor);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void ClearCatchMe()
        {
            var catchMeForm = Program.Services.GetRequiredService<CatchMeMainForm>();
            var graphics = catchMeForm.CreateGraphics();

            var brush = new SolidBrush(catchMeForm.BackColor);
            var rectangle = new Rectangle(x, y, size, size);

            graphics.FillEllipse(brush, rectangle);
        }
        public bool OnForm()
        {
            if (x >= 0 && y >= 0 && x + size <= mainFormBallGameWinFormsApp.ClientSize.Width &&
                y + size <= mainFormBallGameWinFormsApp.ClientSize.Height)
            {
                return true; 
            }

            return false;
        }

        public bool Contains(int pointX, int pointY)
        {
            var radius = size / 2;
            var centerX=x+ radius;
            var centerY=y+ radius;

            return (centerX-pointX)*(centerX-pointX) + (centerY-pointY)*(centerY-pointY)<=radius*radius;
        }
    }
}
