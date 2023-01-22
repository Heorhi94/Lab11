using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Person
{
    public class Pers
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Pers(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
