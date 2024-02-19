using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.FruitNinja
{
    public class BananaFruitBall : FruitBall
    {
         public BananaFruitBall(Form form) : base(form)
        {
            brush = Brushes.Yellow;
            radius = 40;
            
            centerY = form.ClientSize.Height - radius;

        }
    }
}
