Console.WriteLine("Hello, World!");

Task T1 = new(WriteMultipleLines);
T1.Start();


 Console.WriteLine("Hello, World!");
T1.Wait();

Console.WriteLine("Finished");


void WriteMultipleLines() { 


Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");}

