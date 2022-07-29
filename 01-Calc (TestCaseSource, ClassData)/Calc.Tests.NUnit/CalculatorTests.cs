using System.Collections;
using NUnit.Framework;

namespace Calc.Tests.NUnit;

public class CalculatorTests
{
    [Test]
    public void Add_1Plus2_Returns3()
    //public void Add_Should_Return3_When_1Plus2()
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
    //public void Add_Should_Return3_When_2Plus1()
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
    public void Add_APlusB_ReturnsExpectedSum(int a, int b, int expected)
    //public void Add_Should_ReturnExpectedSum_When_APlusB(int a, int b, int expected)
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int actual = calc.Add(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(2, 2, ExpectedResult = 4)]
    [TestCase(2, 3, ExpectedResult = 5)]
    [TestCase(3, 2, ExpectedResult = 5)]
    [TestCase(3, 4, ExpectedResult = 7)]
    [TestCase(5, 6, ExpectedResult = 11)]
    public int Add_APlusB_ReturnsSumFromExpectedResult(int a, int b)
    //public void Add_Should_ReturnSumFromExpectedResult_When_APlusB(int a, int b)
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int actual = calc.Add(a, b);

        // Assert
        return actual;
    }

    [TestCaseSource(typeof(CalcDataClass), nameof(CalcDataClass.TestCases))]   // Data for Act and Assert
    public int Add_APlusB_ReturnsExpectedSum_FromTestCaseCollection(int a, int b)
    //public void Add_Should_ReturnExpectedSum_When_APlusB_FromTestCaseCollection(int a, int b)
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int actual = calc.Add(a, b);

        // Assert
        return actual;
    }
}

public class CalcDataClass
{
    public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(2, 2).Returns(4);
            yield return new TestCaseData(2, 3).Returns(5);
            yield return new TestCaseData(3, 2).Returns(5);
            yield return new TestCaseData(3, 4).Returns(7);
            yield return new TestCaseData(5, 6).Returns(11);
        }
    }
}