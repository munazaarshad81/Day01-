
using Abstraction_OOP;

Undergrad ug = new Undergrad()
{
    Name = "Hassan",
    Id = 123,
    Major = "CE"
};

GradStudent gradstd = new GradStudent()
{
    Name = "Zahra",
    Id = 234,
    ResearchArea ="Artificial Intelligence" 
    
};

ug.StdInfo();
Console.WriteLine("\n-------------------\n");
gradstd.StdInfo();


