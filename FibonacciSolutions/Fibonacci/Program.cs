Console.WriteLine("Fibonacci!");


int a = 1;
int b = 1;
int c = 0;
while(c<100)
{ c = a + b;
    Console.Write($"{c},");
    a = b;
    b = c;
}

