using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{
    internal class Employee
    {
        //Fields
        private String name;
        private int empId;
        private int salary;


        //Constructor to initialise data members 
        public Employee(String name, int empId, int salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;   
        }

        // properties to access private fields and provide controlled access 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int EmployeeId
        {
            get { return empId; }
        }
        public int Salary
        {
            get { return salary; }
            set {

                if (salary > 0)
                {
                    salary = value;
                }
                else { Console.WriteLine("Salary cannot be negative");
                }
           
            
            }
        }
        public void DisplayEmpInfo()
        {
            Console.WriteLine($"Employee Id: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }




    }
}