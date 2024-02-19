using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomMoveBall : RandomPointBall
    {
        public bool bananaEffectActivated { get; set; } = false; 
        public int slowdownFactor { get; set; } = 2; 
        public RandomMoveBall(Form catchMeMForm) : base(catchMeMForm)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        public int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;

            if (bananaEffectActivated)
            {
                return random.Next(2, 5) * sign / slowdownFactor;
            }
            else
            {
                return random.Next(2, 5) * sign;
            }
        }

    }
}
