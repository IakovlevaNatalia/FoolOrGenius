using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class PointBall:Ball
    {
        public PointBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp, int x, int y):base(mainFormBallGameWinFormsApp)
        {
            //var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
            //var brush = Brushes.Aqua;
            //var rectangle = new Rectangle(x-70/2, y-70/2, 70, 70);
            //graphics.FillEllipse(brush, rectangle);
            this.x = x;
            this.y = y;
        }
    }
}
