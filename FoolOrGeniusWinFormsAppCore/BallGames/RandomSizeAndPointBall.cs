using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomSizeAndPointBall:RandomPointBall

    {
        public RandomSizeAndPointBall(CatchMeMainForm catchMe):base(catchMe)
        {
            radius = random.Next(10, 40);
        }
    }
}
