using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class PointBall:Ball
    {
        public PointBall(CatchMeMainForm catchMeForm, int centerX, int centerY):base(catchMeForm)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }
    }
}
