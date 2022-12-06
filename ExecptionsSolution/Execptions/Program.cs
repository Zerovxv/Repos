internal class Program
{
    private static void Main(string[] args)
    {  Method1();  }
    private static void Method1() { Method2(); }
    private static void Method2() { Method3(); }
    private static void Method3() {
        int n = 0;
        int d = 0; 
        try { int x = n / d; }
        catch (DivideByZeroException)
        {   Console.WriteLine("An execption occured");}
        catch (Exception)
        { Console.WriteLine("End of Method3!"); }
        }
    }; bool=



