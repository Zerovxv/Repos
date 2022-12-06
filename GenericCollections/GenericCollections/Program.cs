using GenericCollections;
using System.Runtime.CompilerServices;
Console.WriteLine("Generic Collections!");


int a = 0;
int b = 0;



Stack<int> stack = new();
string eval = "6 6 * 5 6 * + 27 -"; 



string[] parts = eval.Split(" ");
foreach (string part in parts)
{
    switch(part)
    {
        case "+":
            
                a = stack.Pop();
                b = stack.Pop();
                stack.Push(a + b);
                break;
            
            
        case "-":
             a = stack.Pop();
             b = stack.Pop();
            stack.Push(b - a);
            break;
        case "*":
             a = stack.Pop();
             b = stack.Pop();
            stack.Push(a * b);
            break;
        case "/":
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(b / a);
            break;
        default: int nbr = Convert.ToInt32(part);
            stack.Push(nbr);
            break; 
    }
}
static void Output(string Output, IEnumerable<string> collection)
{
    Console.WriteLine(Output);
    foreach (string item in collection)
    {
Console.WriteLine($" {item}");
    }
}

static void WorkingWithLists()
{
    List<string> cities = new();
    cities.Add("London");
    cities.Add("Paris");
    cities.Add("Milan");

    Output("Initial list", cities);
    Console.WriteLine($"The First city is {cities[0]}.");
    Console.WriteLine($"The Last city is {cities[cities.Count - 1]}.");

    cities.Insert(0, "Sydney");
    Output("After inserting Sydney at index 0", cities);

    cities.RemoveAt(1);
    cities.Remove("Milan");

    Output("After removing two cities", cities);


}

static void WorkingWithDictionaries()
{ Dictionary<string, string> keywords = new();

    keywords.Add(key: "int", value: "32-bit integer data type");
    keywords.Add("long", "64-bit integer data type");
    keywords.Add("float", "Single precision floating point number");
    
}


static void WorkingWithQueues()
{
    Queue<string> coffee = new();

    coffee.Enqueue("Damir");
    coffee.Enqueue("Andrea");
    coffee.E
        
        
        
        
        
        }





























Console.WriteLine($"= {stack.Pop()}");



Dictionary<int, Student> students = new();
students.Add(10, new Student { Id = 10, Name = "Noah Phence", SAT = 1200 });
students.Add(20, new Student { Id = 20, Name = "Graham Krakr", SAT = 1200 });

Student noah = students[10]; 




Dictionary<string, string> states = new();
states.Add("OH", "Ohio");
states.Add("KY", "Kentucky");
states.Add("IN", "Indiana");

string state = states["KY"]; 
Console.Write(state);

var x = states.Values.ToList(); 


foreach(var key in states.Keys.ToList())
{ 
    var value = states[key];    

}

List<string> cities = new();
cities.Add("London");
cities.Add("Paris");
cities.Add("London");
cities.Add("Santiago");
cities.Add("Sydney");

cities.Sort();


cities.ForEach(city =>
{
    Console.Write($"{city},");
});


List<int> ints = new(100);






for (int idx = 1; idx < 1000; idx += 13) {
    ints.Add(idx); 
        } 


int sum = 0;

foreach(int idx in ints)
{
    sum += idx;

}
Console.WriteLine(sum);

