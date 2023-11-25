using System;

namespace FoolOrGeniusConsoleApp
{
   internal class Program
    {
        static string [] GetDiagnoses()
        {
            var diagnoses = new string[6];
           
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            return diagnoses;
        }
        private static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine(message + "Введите да или нет");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "нет")
                {
                    return false;
                }
                if (userInput.ToLower()=="да")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Вы ввели непонятную команду. Введите да или нет");
                }
            }
        }
        private static int GetUserAnswer()
        {
            int userAnswer; 

            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Неверный ввод. Введите число");
            }
            return userAnswer;
        }

        static string CalculateDiagnose(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();
            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnoses [percentRightAnswers/20];
        }
        private static void ShowUserResults()
        {
            var result = UserResultsRepository.GetUserResults();
            Console.WriteLine("{0,-20}{1,18}{2,15}", "Имя", "Количество парвильных ответов", "Диагноз");

            foreach (var user in result)
            {
                Console.WriteLine("{0,-20}{1,18}{2,15}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var questions = QuestionsRepository.GetAll();

                var countQuestions = questions.Count;


                Console.WriteLine("Как тебя зовут?");
                var userName = Console.ReadLine();

                var user = new User(userName); 

                var Random = new Random();
                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));

                    var randomQuestionIndex = Random.Next(0, questions.Count);

                    Console.WriteLine(questions[randomQuestionIndex].Text);

                    var rightAnswer = questions[randomQuestionIndex].Answer;

                    var userAnswer = GetUserAnswer();
                    if (userAnswer == rightAnswer)
                    {
                       user.AcceptRightAnswer();
                    }

                    questions.RemoveAt(randomQuestionIndex);
                }
                Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

                var diagnose = CalculateDiagnose(countQuestions,user.CountRightAnswers);
                user.Diagnose=diagnose;
                Console.WriteLine(GetDiagnoses());
                Console.WriteLine(userName + ", " + "ваш диагноз:" + diagnose);

                UserResultsRepository.SaveUserResult(user);


                var userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");

                if (userChoice)
                {
                    UserResultsRepository.SaveUserResult(user);
                }

                userChoice=GetUserChoice("Хотите начать сначала?");

                if (userChoice == false)
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
