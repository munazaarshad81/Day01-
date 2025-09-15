

Console.WriteLine("Hello, World!"); // Prints Hello World and move to a (new) line
//Console.Write("Programming is Fun");// Prints and stays on the same line
//Console.ReadLine(); /*It reads a line of input from the console.
//                     The input ends when the user presses Enter.It always returns a string.*/

/*Data Types in C#
 1- Integer(4bytes) - Long (8bytes)
 2- Float(Decimal 4bytes)  - Double(8byte)
 3- Character(2 bytes) - 
 Bolean(1 bit)- String(2 bytes per character) - 
 ReadLine always returns a string 
 */


/*
 Typecasting in C#: Implicit (done by complier), Explicit(done manually by programmer)
 Convert.ToInt64 , Convert.ToInt32
 Convert.ToDouble
 Convert.ToString 
 */


//string name = Console.ReadLine();
//Console.WriteLine("My name is: " + name);

//Console.WriteLine("How many candies do you want :");
//string can = Console.ReadLine();
//Console.WriteLine("You will get 4 more candies ** " + (Convert.ToInt32(can) + 4));
//Console.ReadLine();
//Console.WriteLine("Please enter your name:");

// Imp Operators: Arithmetic(+,-,*,/), Comparison(<,>,<=,==, !=) , Logical(&& , ||) and Assignment(+=, -=, *=, /=)

/*Imp Functions

string x = "Hey! How are you?";
Console.WriteLine(x);
Console.WriteLine(x.Length);
Console.WriteLine(x.ToLower());
Console.WriteLine(x.ToUpper());
Console.WriteLine(string.Concat(x, "This is reaaly cool"));*/


/* String Interpolation: To add strings, using $ sign instead of concatenation
string name = "Programming is a fun language";
int age = 20;
Console.WriteLine($"Name is {name}, Age is {age}"); */

/* String methods
Console.WriteLine("The index of fun is " + name.IndexOf("fun")); TELLS THE INDEX OF SPECIFIC WORD/CHARACTER
Console.WriteLine(name.Substring(3));  to extract a part of a string from the given index 
 
/" for double quote, /t space, /n newline
 */

/* IF-ELSE  Login simulation
String username = "admin";
int password = 12345;

if (username.Equals("admin") && password.Equals(password)){
   Console.WriteLine("You are logged in to the account");
}
else
{
   Console.WriteLine("Your credentials are not valid");
}*/

/*Grading system

Console.WriteLine("Enter your marks");
int marks = int.Parse(Console.ReadLine());
if (marks > 90)
{
    Console.WriteLine("Grade A");
}
else if (marks > 80)
{
    Console.WriteLine("Grade B");
}
else if (marks > 70)
{
    Console.WriteLine("Grade B-");
}
else if (marks > 50)
{
    Console.WriteLine("Grade C");
}
else if (marks <= 30)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("You didnot pass the course");
} */

/* Switch
int age = 20;
switch (age)
{
    case 10:
        Console.WriteLine("You cannot drive yet");
        break;
        case 15:
        Console.WriteLine("Just wait 3 more years");
        break;
        case 18:
        Console.WriteLine("Congrats you're eligible to drive now!");
        break;
    default:
        Console.WriteLine("This is a default statement");   
        break;
           
} */

/* Loops  while loop
int i = 0;

while (i < 10)
{
    Console.WriteLine(i+1);
    i++;    
}  */
int i = 0;

/* do{
    Console.WriteLine(i + 1);
    i++;
} while (i < 10) ; */

/* break and continue
 break: Leave this loop forever
 cont.:Leave this particular iteration of the loop */

//static void Greet(string name)
//{
//    Console.WriteLine("HEY! Good Morning - " + name );

//}
//static float Average (int x, int y, int z)
//{
//    int sum = x + y + z;
//    Console.WriteLine("The average of x,y,z is: " + sum);

//    return sum/4;
//}
//Average(2, 4, 6);
//Average(3, 5, 7);

//Greet("amna");
//Greet("Mishal");


// Method Overloading
//class Calculator
//{
//    static int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    static int Add(int a, int b)
//    {
//        return a + b;

//    }
//    static double Add(double a, double b) { return a + b; }

//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Sum is: " + Calculator.Add(2, 4, 5));
//        Console.WriteLine("Sum is: " + Calculator.Add(2, 4));
//        Console.WriteLine(Calculator.Add());
//    }
//}









Console.ReadLine();