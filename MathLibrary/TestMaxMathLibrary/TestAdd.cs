
using MAX; 






namespace TestMaxMathLibrary
{
   
    public class TestAdd
    {
        MathLibrary mathlib;
        public TestAdd() { mathlib = new MathLibrary(); }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(-11, 10, -1)]
        public void Test1(int a, int b, int expected) 
        {
            var mathlib = new MathLibrary();
           Assert.Equal(expected, mathlib.Add(a, b));

        }
    }
}