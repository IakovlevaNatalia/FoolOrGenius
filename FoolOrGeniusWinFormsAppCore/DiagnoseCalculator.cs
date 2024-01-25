using System.Data;
using System.Linq;
using FoolOrGenius.Db;
using FoolOrGenius.DbCore.Models;

namespace FoolOrGeniusWinFormsApp
{
    public class DiagnoseCalculator
    {
        private DatabaseContext db;

        public DiagnoseCalculator(DatabaseContext db)
        {
            this.db = db;
        }

        public Diagnosis Calculate(int countQuestions, int countRightAnswers)
        {
            var diagnosis = GetDiagnosis();
            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnosis.Where(x=> percentRightAnswers >= x.MinPercentage).OrderByDescending(x=>x.MinPercentage).First();
        }
        public Diagnosis[] GetDiagnosis()
        {
            return db.Diagnosis.Select(x=>x).ToArray();
        }
    }
}
