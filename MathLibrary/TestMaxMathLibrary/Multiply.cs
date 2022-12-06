using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class Multiply 
    {
        MAX.MathLibrary mathlib; 

        public Multiply() { mathlib = new MAX.MathLibrary(); }
        [Theory]
        [InlineData(0,0, 0)]
        [InlineData(2, 5, 10)]
        [InlineData(3, -4, -12)]
        public void TestMaxMathLibrary(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Multiply(a, b));
        }
    }
}
