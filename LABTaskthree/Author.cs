using System;
using System.Collections.Generic;
using System.Text;

namespace LABTaskthree
{
    internal class Author:Human
    {
       
        public string About;
        public Book[] Books;

        public Author(string name,string surname,int age,string nationality):base(name,surname,age, nationality)
        {
            //this.About = about;
        }
        public override void ShowFullname()
        {
            Console.WriteLine($"FUllname:{Name}{Surname}");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\nAge:{Age}\nNationality:{Nationality}\nAbout:{About}");
        }



    }
}
