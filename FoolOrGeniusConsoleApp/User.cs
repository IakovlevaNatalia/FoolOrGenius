using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoolOrGeniusConsoleApp
{
    internal class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;
        public User(string name)
        {
                Name = name;
                Diagnose = "Неизвестно";
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++; 
        }
    }
}
