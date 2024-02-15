using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class RandomMoveBall : RandomPointBall
    {
        public bool bananaEffectActivated { get; set; } = false; // Флаг, указывающий, активирован ли эффект от BananaFruitBall
        public int slowdownFactor { get; set; } = 2; // Фактор замедления, можно адаптировать в зависимости от ваших требований
        public RandomMoveBall(Form catchMeMForm) : base(catchMeMForm)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        public int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            //if (randomDouble < 0.5)
            //    sign = -1;
            //return random.Next(2, 5) * sign;
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
