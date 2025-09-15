using System;

namespace ImplementingOOP
{
    class Student
    {
        private string name;
        private int age;

        public void SetName(string studentName)
        {
            name = studentName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int studentAge)
        {
            if (studentAge > 0)
                age = studentAge;
            else
                Console.WriteLine("Age must be greater than 0!");
        }

        public int GetAge()
        {
            return age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Person
    {
        public string FullName;
        public void ShowName()
        {
            Console.WriteLine("Person Name: " + FullName);
        }
    }

    class Teacher : Person
    {
        public string Subject;
        public void ShowSubject()
        {
            Console.WriteLine("Teaches: " + Subject);
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal eats food.");
        }
    }

    class Mammal : Animal
    {
        public void Breathe()
        {
            Console.WriteLine("Mammal breathes air.");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape...");
        }
    }

    class Circle : Shape
    {
        public void ShowCircle()
        {
            Console.WriteLine("This is a Circle.");
        }
    }

    class Square : Shape
    {
        public void ShowSquare()
        {
            Console.WriteLine("This is a Square.");
        }
    }

    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public double Add(double a, double b) => a + b;
    }

    class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is driving...");
        }
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The car is driving smoothly...");
        }
    }

    class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The bike is zooming on the road...");
        }
    }

    abstract class Appliance
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is turned ON.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Fan is turned OFF.");
        }
    }

    interface IPlayable
    {
        void Play();
    }

    class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the guitar...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetName("Munaza");
            s1.SetAge(22);
            s1.Display();

            Teacher t1 = new Teacher();
            t1.FullName = "Mr. Ali";
            t1.Subject = "Mathematics";
            t1.ShowName();
            t1.ShowSubject();

            Dog dog1 = new Dog();
            dog1.Eat();
            dog1.Breathe();
            dog1.Bark();

            Circle c1 = new Circle();
            c1.Draw();
            c1.ShowCircle();

            Square sq1 = new Square();
            sq1.Draw();
            sq1.ShowSquare();

            Calculator calc = new Calculator();
            Console.WriteLine("Sum (2+3): " + calc.Add(2, 3));
            Console.WriteLine("Sum (2+3+4): " + calc.Add(2, 3, 4));
            Console.WriteLine("Sum (2.5+3.5): " + calc.Add(2.5, 3.5));

            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Car();
            Vehicle v3 = new Bike();
            v1.Drive();
            v2.Drive();
            v3.Drive();

            Fan fan1 = new Fan();
            fan1.TurnOn();
            fan1.TurnOff();

            Guitar guitar1 = new Guitar();
            guitar1.Play();

            Console.ReadLine();
        }
    }
}
