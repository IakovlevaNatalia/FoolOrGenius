//using System;
//using System.Windows.Forms;
//using System.Threading;
//using FoolOrGeniusWinFormsApp.CatchMe;
//using Timer = System.Windows.Forms.Timer;
//using System.Collections.Generic;

//namespace FoolOrGeniusWinFormsApp.BallGames
//{
//    public class MoveBall : RandomPointBall
//    {
//        //RandomMoveBall ball1;
//        //private RandomMoveBall ball2;
//        //private List<RandomMoveBall> balls;

//        //public MoveBall(Form mainFormBallGameWinFormsApp) : base(mainFormBallGameWinFormsApp)
//        //{

//        //}

//        public MoveBall(CatchMeMainForm catchMeMForm) : base(catchMeMForm)
//        {
//            vx = GenerateRandomProjection();
//            vy = GenerateRandomProjection();
//        }

//        private int GenerateRandomProjection()
//        {
//            var randomDouble = random.NextDouble();
//            var sign = 1;
//            if(randomDouble<0.5)
//                sign = -1;
//            return random.Next(2,5)*sign;
//        }
//    }
//}
