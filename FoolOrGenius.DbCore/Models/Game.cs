using FoolOrGenius.Db.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoolOrGenius.DbCore.Models
{
    public class Game
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int? UserDiagnosis { get; set; }

    }
}

