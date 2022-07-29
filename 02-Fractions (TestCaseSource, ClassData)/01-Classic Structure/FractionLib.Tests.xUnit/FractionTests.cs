using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace FractionLib.Tests.xUnit;

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
        Assert.True(actual);
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
        Assert.False(actual);
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
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 2, 1, 2, 4, 4)]
    [InlineData(1, 2, 1, 3, 5, 6)]
    [InlineData(1, 3, 1, 2, 5, 6)]
    [InlineData(3, 2, 1, 2, 8, 4)]
    [InlineData(1, 2, 3, 2, 8, 4)]
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
        Assert.Equal(expected, actual);
    }

    [Theory, ClassData(typeof(FractionDataClass))]   // Arrange
    public void OperatorPlus_AddTwoFractions(Fraction a, Fraction b, Fraction expected)
    {
        // Act
        var actual = a + b;

        // Assert
        Assert.Equal(expected, actual);
    }
}

public class FractionDataClass : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new()
    {
        new object[] { new Fraction(1, 2), new Fraction(1, 2), new Fraction(4, 4) },
        new object[] { new Fraction(1, 2), new Fraction(1, 3), new Fraction(5, 6) },
        new object[] { new Fraction(1, 3), new Fraction(1, 2), new Fraction(5, 6) },
        new object[] { new Fraction(3, 2), new Fraction(1, 2), new Fraction(8, 4) },
        new object[] { new Fraction(1, 2), new Fraction(3, 2), new Fraction(8, 4) }
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
