using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class Divide
    {
        MAX.MathLibrary mathlib;

        public Divide() { mathlib = new MAX.MathLibrary(); }
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(12, 5, 2)]
        [InlineData(13, -4, -3)]
        public void TestMaxMathLibrary(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Divide(a, b));
        }
    }
}
