using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Calc.Tests.xUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_Should_Return3_When_1Plus2()
        //public void Add_1Plus2_Returns3()
        {
            // Arrange
            var calc = new Calculator();
            var expected = 3;

            // Act
            var actual = calc.Add(1, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_2Plus1_Returns3()
        {
            // Arrange
            var calc = new Calculator();
            int expected = 3;

            // Act
            int actual = calc.Add(2, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 2, 5)]
        [InlineData(3, 4, 7)]
        [InlineData(5, 6, 11)]
        public void Add_APlusB_ReturnsExpectedSum(int a, int b, int expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory, ClassData(typeof(CalcDataClass))]   // Data for Act and Assert
        public void Add_APlusB_ReturnsExpectedSum_FromTestCaseCollection(int a, int b, int expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }

    public class CalcDataClass : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new()
        {
            new object[] { 2, 2, 4 },
            new object[] { 2, 3, 5 },
            new object[] { 3, 2, 5 },
            new object[] { 3, 4, 7 },
            new object[] { 5, 6, 11 }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}