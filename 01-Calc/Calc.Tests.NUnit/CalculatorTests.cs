using NUnit.Framework;

namespace Calc.Tests.NUnit
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_1Plus2_Returns3()
        {
            // Arrange
            var calc = new Calculator();
            var expected = 3;

            // Act
            var actual = calc.Add(1, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_2Plus1_Returns3()
        {
            // Arrange
            var calc = new Calculator();
            int expected = 3;

            // Act
            int actual = calc.Add(2, 1);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 2, 5)]
        [TestCase(3, 4, 7)]
        [TestCase(5, 6, 11)]
        public void Add_Plus_ReturnsResult(int a, int b, int sum)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int actual = calc.Add(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(sum));
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(3, 2, ExpectedResult = 5)]
        [TestCase(3, 4, ExpectedResult = 7)]
        [TestCase(5, 6, ExpectedResult = 11)]
        public int Add_Plus_ReturnsSum(int a, int b)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int actual = calc.Add(a, b);

            // Assert
            return actual;
        }
    }
}