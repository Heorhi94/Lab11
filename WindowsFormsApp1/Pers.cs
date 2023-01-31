using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Person
{
    public class Pers:IComparable<Pers>
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
        public override string ToString()
        {
            return $"{name} {surname}";
        }

        public int CompareTo(Pers obj)
        {
            if (obj is Pers pers) 
            {
                return Surname.CompareTo(pers.Surname);
            }
            else
            {
                throw new ArgumentException("Incorrect parameter value");
            }
          
        }

        public Pers(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
