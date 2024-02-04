using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.CatchMe;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomMoveBall : MoveBall
    {
        private CatchMeMainForm catchMeForm;
        public RandomMoveBall(Form mainFormBallGameWinFormsApp) : base(mainFormBallGameWinFormsApp)
        {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 5);

        }

    }
}
