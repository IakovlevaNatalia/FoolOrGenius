using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoolOrGeniusConsoleApp
{
   internal class Program
    {
        static List<Question> GetQuestions()
        {
            var questions = new List<Question>();

            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?",25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",2));
           
            return questions;
        }
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

        //static void ShuffleArray<T>(ref List <T> array, int? seed = null) 
        //{
        //    var random = new Random(seed??DateTime.Now.Millisecond);

        //    for (int i = array.Count - 1; i > 0; i--)
        //    {
        //        var randomIndex = random.Next(0, i + 1);

        //        T temp = array[i];
        //        array[i] = array[randomIndex];
        //        array[randomIndex] = temp;
        //    }
        //}
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

        static void SaveUserResult (string userName, int countRightAnswers, string diagnose)
        {
            var value = $"{userName}#{countRightAnswers}#{diagnose}";
            AppendToFile("userResults.txt", value);
        }

        static void AppendToFile(string fileName, string value)
        {
            var sw = new StreamWriter(fileName, true, Encoding.UTF8);
            sw.WriteLine(value);
            sw.Close();
        }

        private static void ShowUserResults()
        {
            var sr = new StreamReader("userResults.txt", Encoding.UTF8);

            Console.WriteLine("{0,-20} {1,18} {2,15}", "Имя", "Количество правильных ответов", "Диагноз");

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var value = line.Split('#');
                var name = value [0];
                var countRightAnswers = Convert.ToInt32(value[1]);
                var diagnose = value [2];

                Console.WriteLine("{0,-20} {1,18} {2,15}", name, countRightAnswers, diagnose);
            }
            sr.Close();

        }
        static void Main(string[] args)
        {
            while (true)
            {
                var questions = GetQuestions();
                var countQuestions = questions.Count;

                //var seed = DateTime.Now.Millisecond;

                //ShuffleArray(ref questions, seed);
                //ShuffleArray(ref answers, seed);
                var countRightAnswers = 0;

                Console.WriteLine("Как тебя зовут?");
                var userName = Console.ReadLine();

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
                        countRightAnswers++;
                    }

                    questions.RemoveAt(randomQuestionIndex);
                }
                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);

                var diagnose = CalculateDiagnose(countQuestions, countRightAnswers);
                Console.WriteLine(GetDiagnoses());
                Console.WriteLine(userName + ", " + "ваш диагноз:" + diagnose);

                SaveUserResult(userName, countRightAnswers, diagnose);

                var userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");

                if (userChoice)
                {
                    ShowUserResults();
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
