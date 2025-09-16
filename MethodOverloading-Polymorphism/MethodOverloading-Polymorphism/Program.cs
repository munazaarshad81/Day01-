using MethodOverloading_Polymorphism;
using System.Numerics;

Vehicle v1 = new Vehicle() { Name = "Corolla" , Description="FKQLENVKJEGNkjvnmegnqekvn"}; // Method 1

v1.VehicleInfo();
v1.VehicleInfo("This is the message string"); // second method
v1.VehicleInfo("This is the message string", 20); // third method

