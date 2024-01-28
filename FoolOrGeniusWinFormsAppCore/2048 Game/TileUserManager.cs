using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FoolOrGenius.Db.Models;
using Newtonsoft.Json;
using FoolOrGenius.DbCore.Models;
using FoolOrGeniusLibrary;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public static class TileUserManager
    {
        public static string path = "results.json";
        public static List<UserTile> GetAll()
        {
            if (FileProvider.Exists(path))
            {
                var jsonData = FileProvider.GetValue(path);
                return JsonConvert.DeserializeObject<List<UserTile>>(jsonData);
            }

            return new List<UserTile>();
        }

        public static void Add(UserTile userTile)
        {
            var users = GetAll();
            users.Add(userTile);
            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(path, jsonData);
        }

        //public static void Add(UserTile userTile)
        //{
        //    try
        //    {
        //        var users = GetAll();
        //        users.Add(userTile);
        //        var jsonData = JsonConvert.SerializeObject(users);
        //        FileProvider.Replace(path, jsonData);
        //        MessageBox.Show($"Файл '{path}' успешно обновлен.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
        //    }
        //}
    }
}

