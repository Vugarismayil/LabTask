using System;

namespace LABTaskthree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] b1 = new Book[2];
            Book book = new Book("kitab", "1", 99);
            Book book2 = new Book("kitab2", "2", 199);
            b1[0] = book;
            b1[1] = book2;

            Author a1 = new Author("Vugar", "Ismayilov", 22, "Azerbaijan");
            a1.ShowFullname();
            a1.Books = b1;
            var result = a1.Books;

            foreach (var item in result)
            {
                Console.WriteLine($"Book Name:{item.Name} Book Category: {item.Category} Book Price:{item.Price}");

            }

            //Book book = new Book("1984", "Roman", "muellif", 79.99);

                //Author a1 = new Author("name", "surname", 18, "AZ","null");

                //a1.ShowInfo();
        }
    }
}
