namespace FoolOrGenius.DbCore.Models
{
    public class QuestionResult
    {
        public int QuestionResultId { get; set; }
        public int GameId { get; set;}
        public int UserAnswer { get; set;}
        public bool Result { get; set;}
    }
}
