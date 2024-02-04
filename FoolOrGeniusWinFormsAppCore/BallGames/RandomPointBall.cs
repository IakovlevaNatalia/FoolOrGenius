using System;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.CatchMe;


namespace FoolOrGeniusWinFormsApp.BallGames
{
   public class RandomPointBall:Ball
    {
       
        //public RandomPointBall(Form mainFormBallGameWinFormsApp):base(mainFormBallGameWinFormsApp)
        //{
        //    centerX = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Width);
        //    centerY = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Height);

        //}
     protected static Random random = new Random();

     public RandomPointBall(CatchMeMainForm catchMe):base(catchMe)

     {
         centerX = random.Next(LeftSide(), RightSide());
         centerY = random.Next(TopSide(), DownSide());
     }
    }
}
