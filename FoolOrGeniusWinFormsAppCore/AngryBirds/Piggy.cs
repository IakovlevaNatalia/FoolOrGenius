using System;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.BallGames;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{ 
    public class Piggy:RandomPointBall
    {
        private PictureBox pigPictureBox;
        private Form form;

        public Piggy(Form form, PictureBox pigPictureBox) : base(form)
        {
            this.pigPictureBox = pigPictureBox;
            this.form = form;
            radius = 30;
        }

        public override void Show()
        {
            if (pigPictureBox != null)
            {
                Random random = new Random();
                var randomX = RandomPointBall.random.Next(pigPictureBox.Width / 2, form.ClientSize.Width - pigPictureBox.Width / 2);
                var randomY = RandomPointBall.random.Next(pigPictureBox.Height / 2, form.ClientSize.Height - pigPictureBox.Height / 2);
                pigPictureBox.Location = new Point(randomX, randomY);
            }
        }
    }
}
