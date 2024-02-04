using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class PointBall:Ball
    {
        //public PointBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp, int centerX, int centerY):base(mainFormBallGameWinFormsApp)
        //{
        //    //var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
        //    //var brush = Brushes.Aqua;
        //    //var rectangle = new Rectangle(centerX-70/2, centerY-70/2, 70, 70);
        //    //graphics.FillEllipse(brush, rectangle);
        //    this.centerX = centerX;
        //    this.centerY = centerY;
        //}
        public PointBall(CatchMeMainForm catchMeForm, int centerX, int centerY):base(catchMeForm)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }
    }
}
