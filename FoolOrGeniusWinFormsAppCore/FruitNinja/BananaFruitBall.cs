using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // vy = (float)random.NextDouble() * -6 - 7;
        }

        public  void SetSlowdown(IEnumerable<FruitBall> otherFruits)
        {
            // Реализация замедления для BananaFruitBall
            // Например, уменьшение скорости движения
            //this.vel= 2; // Пример значения скорости для замедления
            foreach (var fruit in otherFruits)
            {
                //fruit.DecreaseVelocity();
                fruit.SetSlowdown();
            }
        }

       
    }
}
