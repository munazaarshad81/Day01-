using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    class FictionBook:Book
    {
        public String genre {  get; set; }

    
        public override void DisplayBookInfo() //The override keyword is used in a derived class to provide a new implementation of a method that was marked virtual (or abstract) in the base class.
        {
            base.DisplayBookInfo();
            Console.WriteLine($"Genre {genre}");
        }
      
    }
}
