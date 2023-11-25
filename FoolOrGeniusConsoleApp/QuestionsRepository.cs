using System;
using System.Collections.Generic;

namespace FoolOrGeniusConsoleApp
{
    class QuestionsRepository
    {
       public static  List<Question> GetAll()
       {
           var questions = new List<Question>();

            if (FileProvider.Exists("questions.txt"))
            {
               var value = FileProvider.GetValue("questions.txt");
               var lines = value.Split('\n');
               foreach (var line in lines)
               {
                   var values = line.Split('#');
                   var text = values[0];
                   var answer = Convert.ToInt32(values[1]);

                   var question = new Question(text, answer);

                   questions.Add(question);
               }
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                foreach (var question in questions)
                {
                    Add(question);
                }
            }
            return questions;
       }
       public static void Add(Question newQuestion)
       {
           var value = $"{newQuestion.Text}#{newQuestion.Answer}";
           FileProvider.Append("questions.txt", value);
       }
    }
}
