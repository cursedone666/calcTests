using System;
using Xunit;
using ConsoleApp9;

namespace TestProject1
{
    public class UnitTest1
    {
        [InlineData(1,2,3)]
        [InlineData(1, 4, 6)]
        [InlineData(5,4,9)]
        [InlineData(4,4,10)]
        [Theory]
        public void Test1(double a, double b, double expectedResult)
        {
            
    

            double sum = Add.Addition(a,b);

            Assert.Equal(expectedResult, sum);
        }

        [Fact]
        public void Test2()
        {
            double num1 = 3;
            double num2 = 69;
            double expectedResult = 66;

            double sum = Sub.Substraction(num2, num1);

            Assert.Equal(expectedResult, sum);
        }
    }
}
