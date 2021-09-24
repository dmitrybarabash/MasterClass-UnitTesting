using System.Collections;
using NUnit.Framework;

namespace FractionLib.Tests.NUnit
{
    public class FractionTests
    {
        [Test]
        public void OperatorEquals_1_2And1_2_ReturnsTrue()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);

            // Act
            var actual = a == b;

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void OperatorEquals_1_2And2_2_ReturnsFalse()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(2, 2);

            // Act
            var actual = a == b;

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void OperatorPlus_1_2And1_2_Returns4_4()
        {
            // Arrange
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);
            var expected = new Fraction(4, 4);

            // Act
            var actual = a + b;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1, 2, 1, 2, 4, 4)]
        [TestCase(1, 2, 1, 3, 5, 6)]
        [TestCase(1, 3, 1, 2, 5, 6)]
        [TestCase(3, 2, 1, 2, 8, 4)]
        [TestCase(1, 2, 3, 2, 8, 4)]
        public void OperatorPlus_AddTwoFractions_ReturnsResult(
            int f1num, int f1denum,
            int f2num, int f2denum,
            int expectedNum, int expectedDenum)
        {
            // Arrange
            var a = new Fraction(f1num, f1denum);
            var b = new Fraction(f2num, f2denum);
            var expected = new Fraction(expectedNum, expectedDenum);

            // Act
            var actual = a + b;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCaseSource(typeof(FractionDataClass), nameof(FractionDataClass.TestCases))]   // Arrange
        public Fraction OperatorPlus_AddTwoFractions(Fraction a, Fraction b)
        {
            // Act
            return a + b;
        }
    }

    public class FractionDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                // Assert
                yield return new TestCaseData(new Fraction(1, 2), new Fraction(1, 2)).Returns(new Fraction(4, 4));
                yield return new TestCaseData(new Fraction(1, 2), new Fraction(1, 3)).Returns(new Fraction(5, 6));
                yield return new TestCaseData(new Fraction(1, 3), new Fraction(1, 2)).Returns(new Fraction(5, 6));
                yield return new TestCaseData(new Fraction(3, 2), new Fraction(1, 2)).Returns(new Fraction(8, 4));
                yield return new TestCaseData(new Fraction(1, 2), new Fraction(3, 2)).Returns(new Fraction(8, 4));
            }
        }
    }
}
