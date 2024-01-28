using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoolOrGenius.DbCore.Models
{
    public class UserTile
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public string Login { get; set; }
        public int Score { get; set; }
        public DateTime GameDateTime { get; set; }

    }
}
