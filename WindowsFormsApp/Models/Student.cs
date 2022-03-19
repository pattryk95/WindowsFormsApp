using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string FullName
        {
            get
            {
                return Imie + " " + Nazwisko;
            }
        }
    }
}
