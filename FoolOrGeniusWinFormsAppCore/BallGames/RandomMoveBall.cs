using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomMoveBall : RandomPointBall
    {
        public RandomMoveBall(Form catchMeMForm) : base(catchMeMForm)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5)
                sign = -1;
            return random.Next(2, 5) * sign;
        }

    }
}
