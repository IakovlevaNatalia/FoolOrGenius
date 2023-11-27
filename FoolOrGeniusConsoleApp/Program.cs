using FoolOrGeniusLibrary;
using System;

namespace FoolOrGeniusConsoleApp
{
   public class Program
    {
        static void AddNewQuestion()
        {
            Console.WriteLine("Введите Ваш вопрос");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = GetNumber();

            var newQuestion = new Question(text, answer);
            QuestionsRepository.Add(newQuestion);
        }
        public static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер вопроса, который хотите удалить");
            var questios = QuestionsRepository.GetAll();

            for (int i = 0; i < questios.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + questios[i].Text);
            }

            var removeQuestionNumber = GetNumber();
            while (removeQuestionNumber<1 || removeQuestionNumber>questios.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questios.Count);
                removeQuestionNumber = GetNumber();
            }

            var removeQuestion = questios[removeQuestionNumber - 1];
            QuestionsRepository.Remove(removeQuestion);

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
        private static int GetNumber()
        {
            int number;

            while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }

            return number;
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
                Console.WriteLine("Hi! What is your name?");
                var user = new User(Console.ReadLine());
                var game = new Game(user);

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();

                    Console.WriteLine(game.GetQuestionNumberText());
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = GetNumber();
                    game.AcceptAnswer(userAnswer);
                }

                var message =game.CalculateDiagnose();  
                Console.WriteLine(message);

                var userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");

                if (userChoice)
                {
                    ShowUserResults();
                }

                userChoice = GetUserChoice("Хотите добавить новый вопрос?");

                if (userChoice)
                {
                    AddNewQuestion();
                }

                userChoice = GetUserChoice("Хотите удалить существующий вопрос?");

                if (userChoice)
                {
                    RemoveQuestion();
                }

                userChoice =GetUserChoice("Хотите начать сначала?");

                if (userChoice == false)
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
