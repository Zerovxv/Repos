using Microsoft.VisualBasic;

Console.WriteLine("Calculate Factorial");

int again = -1;



do
{


    int FactorialNumber = GetIntFromUser("Enter factorial to calculate");


    int factorial = 1;

    for (var idx = 1; idx <= FactorialNumber; idx++)
    {
        factorial *= idx;


    }
    Console.WriteLine($"{FactorialNumber}! is {factorial}");

    again = GetIntFromUser("Enter 0 to quit");

} while (again != 0);






int GetIntFromUser(string message)
{
    Console.Write($"{message}:");
    string response = Console.ReadLine();
    int resp = Convert.ToInt32(response);
    return resp; 



};




int sum = 0;

for(int i = 1000000; i > 0; i--)
{ if(i % 2 == 0) { continue; } 
    sum += i;

}
int[] NewScores = {130, 460, 975, 169, 134,
                    413, 436, 241, 598, 811,
                    589, 726, 933, 906, 326,
                    966, 861, 679, 797, 362,
                    885, 551, 277, 997, 841 }; 

int Score = 0;

foreach(int nbdr in NewScores)
    { Score += nbdr; }
Console.WriteLine($"Sum is {Score}");


for(int i = 1000000; i > 0;i--)
{ if (i % 3 == 0) { continue; }
    sum += i;
}


for (int idk = 0; idk < NewScores.Length; idk++)
{if(idk % 5 ==0 | 7 == 0) { sum += idk;continue;}





}   

for( int idx = 1; idx <=100; idx++)
{
    if (idx % 5 == 0 && idx % 3 == 0)
    {
        Console.Write("FizzBuzz");
        continue;
    }
    if (idx % 3 == 0)
    {
        Console.Write("Fizz");
        continue;
    }
    if (idx % 5 == 0)
    {
        Console.Write("Buzz");
        continue;
    }Console.Write($"{idx}");

}; string strNumber = "2345";
int nbr = Convert.ToInt32(strNumber);
string anotherString = nbr.ToString(); 
var avariavle = 123.ToString();


int anInt = 0;
bool CanConvert = int.TryParse(strNumber, out anInt);
if (!CanConvert)
{
    Console.WriteLine("The string could not be converted");
} else { Console.WriteLine($"The converted value is {anInt}"); 
};






