using NUnit.Framework;
using FluentAssertions;

namespace FractionLib.Tests.NUnitAndFluentAssertions
{
    public class FractionTests
    {
        [Test]
        public void OperatorEquals_Should_ReturnTrue_When_1_2And1_2()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);

            // Act
            var actual = a == b;

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void OperatorEquals_Should_ReturnFalse_When_1_2And2_2()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(2, 2);

            // Act
            var actual = a == b;

            // Assert
            actual.Should().BeFalse();
        }

        [Test]
        public void OperatorPlus_Should_Return4_4_When_1_2And1_2()
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
