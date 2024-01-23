//using System;
//using System.Collections.Generic;

//namespace FoolOrGeniusLibrary
//{
//    public class GameService
    
//        private User user;
//        private List<Question> questions;
//        private Question currentQuestion;
//        private int questionNumber = 0;
//        private int countQuestions;

//        public GameService(User user)
//        {
//            this.user = user;
//            questions = QuestionsRepository.GetAll();
//            countQuestions = questions.Count;
//        }

//        public Question GetNextQuestion()
//        {
//            var random = new Random();
//            var RandomQuestionIndex = random.Next(0, questions.Count);
//            currentQuestion = questions[RandomQuestionIndex];

//            questionNumber++;
//            return currentQuestion;
//        }

//        public void AcceptAnswer(int userAnswer)
//        {
//            var rightAnswer = currentQuestion.Answer;
//            if (userAnswer == rightAnswer)
//            {
//                user.AcceptRightAnswer();
//            }

//            questions.Remove(currentQuestion);
//        }
//        public string GetQuestionNumberText()
//        {
//            return "Question №" + questionNumber;
//        }

//        public bool End()
//        {
//            return questions.Count == 0;
//        }

//        public string CalculateDiagnose()
//        {
//            var diagnose = DiagnoseCalculator.Calculate(countQuestions, user.CountRightAnswers);
//            user.Diagnose = diagnose;
//            UserResultsRepository.Append(user);

//            return user.Name + ", Your diagnosis is: " + user.Diagnose;
//        }

//    }
//}
