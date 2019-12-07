using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 7, 3, 20)]
        [InlineData(100, 75, 25, 200)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-5, 5, -10, -10)]
        [InlineData(-10, -7, -17, -34)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 7, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(100, 25, 75)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            double actual = challenger.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 7, 70)]
        [InlineData(100, 75, 7500)]
        [InlineData(1, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -25)]
        public void Multiply(long factor1, long factor2, long product)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            long actual = challenger.Multiply(factor1, factor2);
            //Assert
            Assert.Equal(product, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(25, 5, 5)]
        [InlineData(3.14, -1.72, -1.826)]
        [InlineData(10, 0, 0)]
        [InlineData(-100, -10, 10)]
        public void Divide(double dividend, double divisor, double quotient)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            double actual = challenger.Divide(dividend, divisor);
            //Assert
            Assert.Equal(quotient, actual);
        }

        [Theory]
        [InlineData("kayak", true)]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("apple", false)]
        [InlineData("banana", false)]
        [InlineData("orange", false)]

        public void IsStringAPalindrome(string input, bool expected)
        {
            // Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            // Act
            bool actual = challenger.IsStringAPalindrome(input);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Mike", true)]
        [InlineData("Michael", true)]
        [InlineData("Mikey", true)]
        [InlineData("mike", true)]
        [InlineData("mikey", true)]
        [InlineData("stan", false)]
        [InlineData("Jeff", false)]
        [InlineData("michelle", false)]
        [InlineData("jessica", false)]

        public void IsYourNameMyName(string name, bool expected)
        {
            // Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            // Act
            bool actual = challenger.IsYourNameMyName(name);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
