using System.Collections.Generic;
using Newtonsoft.Json;

namespace FoolOrGeniusLibrary
{
    public class UserResultsRepository
    {
        public static string Path = "UserResults.json";
        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);

        }
        public static List<User> GetAll()
        {
            if(!FileProvider.Exists(Path))
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetValue(Path); 
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }

        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

    }
}
