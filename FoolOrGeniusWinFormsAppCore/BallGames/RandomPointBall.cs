using System;
using System.Drawing;


namespace FoolOrGeniusWinFormsApp.BallGames
{
   public class RandomPointBall:Ball
    {
       protected static Random random = new Random();
        public RandomPointBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp):base(mainFormBallGameWinFormsApp)
        {
            x = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Width);
            y = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Height);

        }
     
    }
}
