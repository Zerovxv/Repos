using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    internal class Major
    {
        public string Code { get; set; }
        public string description { get; set; }
        public int MinSAT { get; set; }

        public void Print()
        { string message = $"{Code}\t{description}\t{MinSAT}"; 
            System.Console.WriteLine(message);
        }
    }
}