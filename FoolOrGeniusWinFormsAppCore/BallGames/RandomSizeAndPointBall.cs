

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomSizeAndPointBall:RandomPointBall

    {
        public RandomSizeAndPointBall(MainFormBallGameWinFormsApp mainFormBallGameWinFormsApp):base(mainFormBallGameWinFormsApp)
        {
            size = random.Next(30, 80);
        }
    }
}
