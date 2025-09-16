using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_OOP
{
    class Undergrad:Student
    {
        public string Major {  get; set; }
     

        public override void StdInfo()
        {
            Console.WriteLine($"Undergraduate student \nName: {Name} \nID: {Id} \nMajor: {Major}");
        }
    }
}
