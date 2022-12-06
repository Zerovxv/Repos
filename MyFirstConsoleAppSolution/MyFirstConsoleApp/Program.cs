// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;


MAX.Console.Run("Caleb");

Console.WriteLine("Hello, World!");


if (true)
{
    Console.WriteLine("The if statement is true!");
    Console.WriteLine("We want to execute this statement also if true");
}

Console.WriteLine("This statement will always execute regardless of the if statement");


MAX.Student s = new MAX.Student();
s.Firstname = "Noah";
s.Lastname = "Phence";

Console.WriteLine(s.Firstname + " " + s.Lastname); 

MAX.Student caleb = new MAX.Student();
caleb.Firstname = "Caleb";
caleb.Lastname = "Butcher";
Console.WriteLine(caleb.Fullname());



M.Major math = new M.Major();
math.Code = "Math";
math.description = "Mathematics";
math.MinSAT = 1200;
math.Print();

M.Major bus = new M.Major();
bus.Code = "BUS";
bus.description = "Business";
bus.MinSAT = 400;
bus.Print();


// variable

int i = 13;
int j = 3;
int sum = i + j;
int diff = i - j;
int prod = i * j;
decimal div = i / (decimal)j; 


Console.WriteLine($" {i} + {j} = {sum}");
Console.WriteLine(i + " + " + j + " = " + sum);




Console.WriteLine($"{sum} {diff} {prod} {div}");



decimal variable = 0.0m;









Person kim = new();
kim.Name = "Kim";
kim.Birthdate = new(2022, 08, 26);

class Person { public DateTime Birthdate; } 
