using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp.CatchMe;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class Ball
    {
       private Form mainFormBallGameWinFormsApp;
       private Form catchMeForm;
       private Timer timer;

       protected int vx = 10; 
       protected int vy = 10;
       protected int centerX = 10;
       protected int centerY = 10;
       protected int radius = 25;
       protected static Random random = new Random();

        //public Ball(Form mainFormBallGameWinFormsApp)
        //{
        //    this.mainFormBallGameWinFormsApp= mainFormBallGameWinFormsApp;
        //}

        public Ball(Form catchMeForm)
        {
            this.catchMeForm= catchMeForm;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
           timer.Stop();
        }

     private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Move()
        {
            ClearCatchMe();
            HandleEdgeCollision();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return catchMeForm.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return catchMeForm.ClientSize.Height - radius;
        }
        private void HandleEdgeCollision()
        {
            var catchMeForm = Program.Services.GetRequiredService<CatchMeMainForm>();

            if (centerX <= 0 || centerX + radius >= catchMeForm.ClientSize.Width)
            {
                vx = -vx; 
            }

            if (centerY <= 0 || centerY + radius >= catchMeForm.ClientSize.Height)
            {
                vy = -vy; 
            }
        }
      

        //public void Show() либо удалить , либо вернуть раб метод
        //{
        //    var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
        //    var brush = Brushes.Aqua;
        //    var rectangle = new Rectangle(centerX-radius, centerY-radius, 2*radius, 2*radius);
        //    graphics.FillEllipse(brush, rectangle);
        //}

        public void Show()
        {
            var brush = Brushes.DarkRed;
            Draw(brush);
        }

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        //public void Clear() раскоментировать после 
        //{
        //    var graphics = mainFormBallGameWinFormsApp.CreateGraphics();
        //    var brush = new SolidBrush(mainFormBallGameWinFormsApp.BackColor);
        //    var rectangle = new Rectangle(centerX, centerY, radius, radius);
        //    graphics.FillEllipse(brush, rectangle);
        //}

        //public void ClearCatchMe() работающий метод
        //{
        //    var catchMeForm = Program.Services.GetRequiredService<CatchMeMainForm>();
        //    var graphics = catchMeForm.CreateGraphics();

        //    var brush = new SolidBrush(catchMeForm.BackColor);
        //    var rectangle = new Rectangle(centerX, centerY, radius, radius);

        //    graphics.FillEllipse(brush, rectangle);
        //}

        public void ClearCatchMe()
        {
            var brush = new SolidBrush(catchMeForm.BackColor);
            Draw(brush);
        }
        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX<=RightSide() && centerY>=TopSide() && centerY<=DownSide();
 
        }

        //public bool Contains(int pointX, int pointY)
        //{
        //    var radius = this.radius / 2;
        //    var centerX=this.centerX+ radius;
        //    var centerY=this.centerY+ radius;

        //    return (centerX-pointX)*(centerX-pointX) + (centerY-pointY)*(centerY-pointY)<=radius*radius;
        //}

        public bool Contains(int pointX, int pointY)
        {

            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx*dx+dy*dy<=radius*radius;
        }

        private void Draw(Brush brush)
        {
            var graphics = catchMeForm.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
