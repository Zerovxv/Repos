using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTutorial
{ 
    public static class IntegerExtensionMethods
    {
        public static int Add(this int i, int j)
        {
            return i + j;
        }

        public static int Sub(this int i, int j)
        {
            return i - j;
        }
        public static int Mult(this int i, int j)
        {
            return i * j;
        }
        public static int Div(this int i, int j)
        {
            return i / j;
        }
        public static void CW(this int i)
        {
            Console.WriteLine($"{i}");
        }

    }
    public static class ExtensionMethods
    {

        /*
         * string title = "LinqWithEfCore";
         *  title.Write();        
         */

        public static void CW(this string str)
        { Console.WriteLine($"{str}"); }





        public static string AppendString(this string str,string appendStr)
        {
            return $"{str} {appendStr}";

        }

        public static void Write(this string str) 
        { Console.WriteLine($"{str} using extension method WRITE"); }
    }
}
