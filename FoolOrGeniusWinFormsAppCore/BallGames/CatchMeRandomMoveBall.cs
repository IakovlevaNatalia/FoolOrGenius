using FoolOrGeniusWinFormsApp.CatchMe;


namespace FoolOrGeniusWinFormsApp.BallGames
{
    public class CatchMeRandomMoveBall:MoveBall
    {
  
         private CatchMeMainForm catchMeMainForm;

         public CatchMeRandomMoveBall(CatchMeMainForm catchMeMainForm) : base(catchMeMainForm)
         {
             vx = random.Next(-5, 6);
             vy = random.Next(-5, 5);
             this.catchMeMainForm = catchMeMainForm;
         }

    }
}
