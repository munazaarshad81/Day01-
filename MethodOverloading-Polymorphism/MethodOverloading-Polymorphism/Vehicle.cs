using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_Polymorphism
{
    internal class Vehicle
    {
        public String Name { get; set; }
        public String Description { get; set; }

        public void VehicleInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}");
            
        }
        public void VehicleInfo(string message)
        {
            Console.WriteLine ($"Name: {Name}, Description{Description}, {message}");
        }
        public void VehicleInfo(string message, int age)
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Message: {message},Age{age}");
        }
    }
}
