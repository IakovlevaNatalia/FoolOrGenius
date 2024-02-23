using FoolOrGenius.Db;
using FoolOrGenius.DbCore.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public class GameService2048
    {
        private DatabaseContext db;
        private UserFactory userFactory;


        public GameService2048(UserFactory userFactory, DatabaseContext db)
        {
            this.userFactory = userFactory;
            this.db = db;
        }
        public void SaveGameResult(int mapSize, int score, bool isVictory)
        {
            var game2048Type = db.Game2048Type.Single(x => x.MapSize == mapSize);

            var bestScore = db.Game2048.Where(x => x.UserId == userFactory.ExistingUser.Id).Select(x=>x.Score).DefaultIfEmpty().Max();

            Game2048 game2048 = new Game2048();


            if (userFactory != null && userFactory.ExistingUser != null)
            {
                game2048.UserId = userFactory.ExistingUser.Id;
                game2048.Login = userFactory.ExistingUser.Login;
            }
            else
            {
                MessageBox.Show("UserFactory or ExistingUser are null");
                return;
            }
            if (game2048Type != null)
            {
                game2048.GameTypeId = game2048Type.GameTypeId;
            }
            else
            {
                MessageBox.Show("Game2048Type is null");

                return;
            }
            if (db != null)
            {
                game2048.Score = score;
                game2048.Result = isVictory;
                game2048.GameDateTime = DateTime.Now;

                db.Game2048.Add(game2048);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("db null");
                return;
            }
        }
    }
}
