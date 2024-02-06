using System;
using System.Windows.Forms;


namespace FoolOrGeniusWinFormsApp.BallGames
{
   public class RandomPointBall:Ball
   {

     protected static Random random = new Random();
     public RandomPointBall(Form catchMe):base(catchMe)
     {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
   }
}
