using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoolOrGenius.DbCore.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public string DiagnosisName { get; set; }

        public int MinPercentage { get; set; }
    }
}
