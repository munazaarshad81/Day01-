using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_OOP
{
    abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    //Abstract Method, (abstract keyword, cannot be implemented in the base class)
        public abstract void StdInfo();

    //Non Abstract Method- no abstract keyword and can be implemented  
        public void WelcomeMessgae()
        {
            Console.WriteLine("Welcome to the student management ");
        }
    }
}
