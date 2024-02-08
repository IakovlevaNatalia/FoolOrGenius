using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    public class Piggy:RandomMoveBall
    {
        protected Brush brush;
        public Piggy(Form form):base(form)
        {
            brush = Brushes.Pink;
            radius = 30;
        }

        public override void Show()
        {
            Draw(brush);
        }
    }
}
