using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoolOrGeniusConsoleApp
{
    internal class UserResultsRepository
    {
        public static void SaveUserResult(User user)
        {
            var value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnose}";
            AppendToFile("userResults.txt", value);
        }
        static void AppendToFile(string fileName, string value)
        {
            var sw = new StreamWriter(fileName, true, Encoding.UTF8);
            sw.WriteLine(value);
            sw.Close();
        }
        public static List<User> GetUserResults()
        {
            var sr = new StreamReader("userResults.txt", Encoding.UTF8);
            var results = new List<User>(); 

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var value = line.Split('#');
                var name = value[0];
                var countRightAnswers = Convert.ToInt32(value[1]);
                var diagnose = value[2];
                
                var user = new User(name);
                user.CountRightAnswers = countRightAnswers;
                user.Diagnose = diagnose;
                results.Add(user);
            }
            sr.Close();

            return results;
        }
    }
}
