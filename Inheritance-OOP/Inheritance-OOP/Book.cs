using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    abstract class Book
    {
        public String book_Name { get; set; }
        public String Author { get; set; }
        public int book_Price { get; set;}
        
        public string Description {  get; set; }

        public virtual void DisplayBookInfo() /*When you mark a method in a base class as "virtual", you are telling C#:
                                                ➡️ “This method can be overridden in derived classes if needed.”*/
        {
            Console.WriteLine($"Book Name: {book_Name}");
            Console.WriteLine($"Book Title: {Author}");
            Console.WriteLine($"Book Price:{book_Price}");

        }
      
    }
}
