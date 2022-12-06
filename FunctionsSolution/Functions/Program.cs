Console.WriteLine("Functions Tutorial!");

TimesTable(9) ;

int Multiply(int i, int j) { return i * j; }

void TimesTable(int Nbr = 12) { 

    if(Nbr <=12 &&Nbr >0) { throw new Exception("TimesTable requires an int 1<= nbr <=12"); };

for (int idx = 1; idx <= 12; idx++)
{ Console.WriteLine($"{idx} x {Nbr} = {Multiply(idx, Nbr)}");
};
