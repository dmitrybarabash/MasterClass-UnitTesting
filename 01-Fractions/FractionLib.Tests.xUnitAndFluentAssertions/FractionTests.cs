using Xunit;
using FluentAssertions;

namespace FractionLib.Tests.xUnitAndFluentAssertions
{
    public class FractionTests
    {
        [Fact]
        public void OperatorEquals_1_2And1_2_ReturnsTrue()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);

            // Act
            var actual = a == b;

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void OperatorEquals_1_2And2_2_ReturnsFalse()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(2, 2);

            // Act
            var actual = a == b;

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void OperatorPlus_1_2And1_2_Returns4_4()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);
            var expected = new Fraction(4, 4);

            // Act
            var actual = a + b;

            // Assert
            actual.Should().Equals(expected);
        }
    }
}
