using System.Collections.Specialized;

Console.WriteLine("Factorial!");


int target = 6;
int product = Factorial(target);





int Factorial( int nbr) { 
    if(nbr == 1)
    { return 1; }
    return nbr * Factorial(nbr - 1);
   
    
    
int FactorialLoop(int nbr) { int product = 1; }


    for (int idx = 1; idx <= target; idx++) {
   / product *= idx; }
    return product;


}
Console.WriteLine($"{target}! is {product}"); 