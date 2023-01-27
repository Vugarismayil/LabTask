using System;
using System.Collections.Generic;
using System.Text;

namespace LABTaskthree
{
    internal class Book
    {
        public string Name;
        public string Category;
        
        public double Price;


        public Book(string name,string category,double price)
        {
            this.Name = name;
            this.Category = category;
            
            this.Price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\nCategory:{Category}\n\nPrice:{Price}");
        }

        

    }

    
}
