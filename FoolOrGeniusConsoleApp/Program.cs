﻿using System;

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

        public static string[] GetDiagnoses()
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
        private static int GetNumber()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введите число от -2*10^9 до 2*10^9!");
                }
            }
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

                    var userAnswer = GetNumber();
                    if (userAnswer == rightAnswer)
                    {
                       user.AcceptRightAnswer();
                    }
                    questions.RemoveAt(randomQuestionIndex);
                }
                Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

                user.Diagnose = CalculateDiagnose(countQuestions,user.CountRightAnswers);
          
                Console.WriteLine(GetDiagnoses());
                Console.WriteLine(userName + ", " + "ваш диагноз:" + user.Diagnose);

                UserResultsRepository.Save(user);
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
