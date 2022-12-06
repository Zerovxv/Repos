using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class Subtract  
    {
        MAX.MathLibrary mathlib;

        public Subtract() { mathlib = new MAX.MathLibrary(); }
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(10, 2, 8)]
        [InlineData(3, -4, 7)]
        public void TestMaxMathLibrary(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Subtract(a, b));
        }
    }
}

