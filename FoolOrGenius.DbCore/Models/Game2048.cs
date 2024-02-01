using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoolOrGenius.Db.Models;

namespace FoolOrGenius.DbCore.Models
{
    public class Game2048
    {
        [Key]
        public int GameId { get; set; }

        [ForeignKey("GameType")]
        public int GameTypeId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public Game2048Type GameType { get; set; }

        public User User { get; set; }

        public string Login { get; set; }
        public int Score { get; set; }
        public bool Result { get; set; }
        public DateTime GameDateTime { get; set; }
    }
}
