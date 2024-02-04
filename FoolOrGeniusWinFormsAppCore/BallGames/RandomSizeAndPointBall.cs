

using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomSizeAndPointBall:RandomPointBall

    {
        //public RandomSizeAndPointBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp):base(mainFormBallGameWinFormsApp)
        //{
        //    radius = random.Next(30, 80);
        //}
        public RandomSizeAndPointBall(CatchMeMainForm catchMe):base(catchMe)
        {
            radius = random.Next(10, 40);
        }
    }
}
