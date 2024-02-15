using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomSizeAndPointBall:RandomPointBall

    {
        public RandomSizeAndPointBall(Form form):base(form)
        {
            radius = random.Next(10, 40);
        }
    }
}
