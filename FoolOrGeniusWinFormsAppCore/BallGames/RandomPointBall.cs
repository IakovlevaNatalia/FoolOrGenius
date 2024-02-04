using System;
using System.Drawing;
using System.Windows.Forms;


namespace FoolOrGeniusWinFormsApp.BallGames
{
   public class RandomPointBall:Ball
    {
        public RandomPointBall(Form mainFormBallGameWinFormsApp):base(mainFormBallGameWinFormsApp)
        {
            x = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Width);
            y = random.Next(0, mainFormBallGameWinFormsApp.ClientSize.Height);

        }
     
    }
}
