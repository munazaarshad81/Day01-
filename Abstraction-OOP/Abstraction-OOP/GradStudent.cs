using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_OOP
{
    class GradStudent:Student
    {
        public String ResearchArea {  get; set; }

        public override void StdInfo()
        {
            Console.WriteLine($"Graduate student \nName:  {Name} \nID: {Id}\nResearchArea: {ResearchArea}");
        }
    }
}
