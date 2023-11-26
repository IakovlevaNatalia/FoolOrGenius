//using System;
//using System.Collections.Generic;

//namespace FoolOrGeniusConsoleApp
//{
//    internal class UserResultsRepository
//    {

//        public static void Save(User user)
//        {
//            var value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnose}";
//            FileProvider.Append("userResults.txt", value);
//        }
//        public static List<User> GetUserResults()
//        {
//            var value = FileProvider.GetValue("userResults.txt");
//            var lines = value.Split(new char[]{'\n'}, StringSplitOptions.RemoveEmptyEntries);
//            var results = new List<User>();

//            foreach (var line in lines)
//            {
//                var values = line.Split('#');
//                var name = values[0];
//                var countRightAnswers = Convert.ToInt32(values[1]);
//                var diagnose = values[2];

//                var user = new User(name);
//                user.CountRightAnswers = countRightAnswers;
//                user.Diagnose = diagnose;
//                results.Add(user);
//            }

//            return results;
//        }

//    }
//}
