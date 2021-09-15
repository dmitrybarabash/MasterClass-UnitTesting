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
        public void Add_Plus_ReturnsResult(int a, int b, int sum)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int actual = calc.Add(a, b);

            // Assert
            Assert.Equal(sum, actual);
        }
    }
}