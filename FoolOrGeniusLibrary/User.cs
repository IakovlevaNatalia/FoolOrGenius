namespace FoolOrGeniusLibrary
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;
        public User(string name)
        {
                Name = name;
                Diagnose = "Неизвестно";
        }
        public void AcceptRightAnswer()
        {
            CountRightAnswers++; 
        }
    }
}
