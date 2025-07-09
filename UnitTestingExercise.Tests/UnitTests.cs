using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 2, 4, 6)]
        [InlineData(-1, -2, -5, -8)]
        [InlineData(-2, 3, -5, -4)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var c = new Calculator();

            var actual = c.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(0, 2, -2)]
        [InlineData(-1, -2, 1)]
        [InlineData(-2, 3, -5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            var c = new Calculator();

            var actual = c.Subtract(minuend, subtrahend);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 2, 0)]
        [InlineData(-1, -2, 2)]
        [InlineData(-2, 3, -6)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var c = new Calculator();

            var actual = c.Multiply(num1, num2);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(2, 1, 2)]
        [InlineData(16, -4, -4)]
        [InlineData(27, 3, 9)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var c = new Calculator();
            if (num2 == 0)

            {
                Assert.Throws<DivideByZeroException>(() => c.Divide(num1, num2));
                return; // Skip the assertion below if we expect an exception
            }

            var actual = c.Divide(num1, num2);

            Assert.Equal(expected, actual);


        }

    }
}
