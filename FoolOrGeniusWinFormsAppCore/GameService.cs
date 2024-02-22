using System;
using System.Collections.Generic;
using System.Linq;
using FoolOrGenius.Db;
using FoolOrGenius.DbCore.Models;
using Question = FoolOrGenius.DbCore.Models.Question;

namespace FoolOrGeniusWinFormsApp
{
    public class GameService
    {
        private DatabaseContext db;
        private UserFactory userFactory;
        private List<Question> questions;
        private Question currentQuestion;
        private int questionNumber = 0;
        private int countQuestions;
        public int countRightAnswers;
        private DiagnoseCalculator diagnoseCalculator;
        private Game currentGame;
        private Game2048 game2048;

        public GameService(UserFactory userFactory, DatabaseContext db, DiagnoseCalculator diagnoseCalculator)
        {
            this.userFactory = userFactory;
            this.db = db;
            this.diagnoseCalculator = diagnoseCalculator;
            GetAllQuestions();
            countQuestions = questions.Count;
        }

        private void GetAllQuestions()
        {
            questions = db.Question.Select(x=>x).ToList();
        }

        public void StartNewGame()
        {
            currentGame = new Game
            {
                UserId = userFactory.ExistingUser.Id,
            };

            db.Add<Game>(currentGame);
            db.SaveChanges();
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];

            questionNumber++;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var answer = new QuestionResult()
            {
                GameId = currentGame.GameId,
                UserAnswer = userAnswer
            };
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                countRightAnswers++;
                answer.Result = true;
            }
            else
            {
                answer.Result = false;
            }

            db.QuestionResult.Add(answer);
            db.SaveChanges();

            questions.Remove(currentQuestion);
        }
        public string GetQuestionNumberText()
        {
            return "Question №" + questionNumber;
        }

        public bool End()
        {
            return questions.Count == 0;
        }

        public string CalculateDiagnosis()
        {
            var diagnosis = diagnoseCalculator.Calculate(countQuestions, countRightAnswers);

            currentGame.UserDiagnosis = diagnosis.Id;

            db.Diagnosis.Update(diagnosis);
            db.SaveChanges();

            return userFactory.ExistingUser.FirstName + ", your diagnosis is: " + diagnosis.DiagnosisName;
        }


     
    }
}
