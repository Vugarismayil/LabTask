using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LABTaskthree
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Nationality;

        public Human(string name,string surname,int age,string nationality)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Nationality = nationality;
        }

        public virtual void ShowFullname()
        {
            Console.WriteLine($"Name:{Name}Surname:{Surname}");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\nAge:{Age}\nNationality{Nationality}");
        }
    }
}
