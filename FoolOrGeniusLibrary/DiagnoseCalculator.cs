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

            diagnoses[0] = "egg";
            diagnoses[1] = "chick";
            diagnoses[2] = "hen";
            diagnoses[3] = "developed";
            diagnoses[4] = "talent";
            diagnoses[5] = "genius";

            return diagnoses;
        }
    }
}
