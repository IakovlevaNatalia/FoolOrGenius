using System;

namespace FoolOrGeniusConsoleApp
{
    internal class Program
    {
        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            return questions;
        }
        static string [] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
           
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            return diagnoses;
        }
        static int [] GetAnswers(int countQuestions)
        {
            int[] answers = new int[countQuestions];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;
            return answers;
        }

        static void ShuffleArray<T>(ref T[] array, int? seed = null) 
        {
            var random = new Random(seed??DateTime.Now.Millisecond);

            for (int i = array.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                T temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
   
            }
        }
        private static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine(message + "Введите да или нет");
                string userInput = Console.ReadLine();

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
        static void Main(string[] args)
        {
            while (true)
            {
                int countQuestions = 5;
                string[] questions = GetQuestions(countQuestions);
                int[] answers = GetAnswers(countQuestions);
                string[] diagnoses = GetDiagnoses();

                var seed = DateTime.Now.Millisecond;

                ShuffleArray(ref questions, seed);
                ShuffleArray(ref answers, seed);
                int countRightAnswers = 0;

                Console.WriteLine("Как тебя зовут?");
                string userName = Console.ReadLine();

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));
                    Console.WriteLine(questions[i]);

                    int rightAnswer = answers[i];
                    bool successTry = false;

                    while (!successTry) 
                    {
                        successTry = int.TryParse(Console.ReadLine(), out var userAnswer);

                        if (successTry)
                        {
                            if (userAnswer == rightAnswer)
                                countRightAnswers++;
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Введите число");
                        }
                    } 
                }
                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);
                Console.WriteLine(GetDiagnoses());
                Console.WriteLine(userName + ", " + "ваш диагноз:" + diagnoses[countRightAnswers]);

                bool userChoice=GetUserChoice("Хотите начать сначала?");
                if (userChoice == false)
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
