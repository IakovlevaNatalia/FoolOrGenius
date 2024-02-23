using System.ComponentModel.DataAnnotations;

namespace FoolOrGenius.DbCore.Models
{
    public class Game2048Type
    {
        [Key]
        public int GameTypeId { get; set; }

        public string GameType { get; set; }

        public int MapSize { get; set; }

    }
}
