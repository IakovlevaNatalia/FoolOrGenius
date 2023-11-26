using System;

namespace FoolOrGeniusLibrary
{
    public class DiagnoseCalculator
    {
        public static string Calculate(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();
            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnoses[percentRightAnswers / 20];
        }

        public static string [] GetDiagnoses ()
        {
            var diagnoses = new string[6];

            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            //var userDiagnose = diagnoses[user.CountRightAnswers];
            //return user.Name + ", Ваш диагноз: " + userDiagnose;
            return diagnoses;
        }
    }
}
