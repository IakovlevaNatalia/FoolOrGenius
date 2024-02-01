using System.Collections.Generic;
using Newtonsoft.Json;
using FoolOrGenius.DbCore.Models;
using FoolOrGeniusLibrary;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public static class TileUserManager
    {
        public static string path = "results.json";
        public static List<Game2048Type> GetAll()
        {
            if (FileProvider.Exists(path))
            {
                var jsonData = FileProvider.GetValue(path);
                return JsonConvert.DeserializeObject<List<Game2048Type>>(jsonData);
            }

            return new List<Game2048Type>();
        }

        public static void Add(Game2048Type game2048)
        {
            var users = GetAll();
            users.Add(game2048);
            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(path, jsonData);
        }

    }
}

