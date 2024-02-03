using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class Ball
    {
       private MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp;
       private int vx = 1; //задает сторону движения и скорость, чем выше тем быстрее
       private int vy = 1;
       protected int x = 150;
       protected int y = 150;
       protected int size = 70;
        public Ball(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp)
        {
            this.mainFormBallGameWinFormsApp= mainFormBallGameWinFormsApp;
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
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

        private void Clear()
        {
            var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }


    }
}
