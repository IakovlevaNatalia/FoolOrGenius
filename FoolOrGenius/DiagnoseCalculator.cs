namespace FoolOrGeniusLibrary
{
    public class DiagnoseCalculator
    {
        public static string Calculate (int countQuestions, User user)
        {
            var diagnoses = new string[6];

            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            var userDiagnose = diagnoses[user.CountRightAnswers];
            return user.Name + ", Ваш диагноз: " + userDiagnose;
        }
    }
}
