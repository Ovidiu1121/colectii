using System;
using Xunit;
using Xunit.Abstractions;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Given
            int a = 5;
            int b = 10;
            int expectedSum = 15;

            // when
            int result = a+b;
            // then
            Assert.Equal(expectedSum, result);
        }

        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum2()
        {
            int a = 5;
            int b = 10;
            int expectedSum = 15;

            int result = a+b;

            output.WriteLine($"Sum of {a} and {b} is {result}");
            Assert.Equal(expectedSum, result);
        }

        [Fact]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int dividend = 10;
            int divisor = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => dividend/divisor) ;
        }


    }
}