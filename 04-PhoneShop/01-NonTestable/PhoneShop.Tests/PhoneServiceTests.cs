using NUnit.Framework;
using PhoneShop.Services;

namespace PhoneShop.Tests;

public class PhoneServiceTests
{
    [Test]
    public void IsPhoneAvalable_Should_ReturnTrue_When_BrandIsSamsungAndModelIsGalaxyS21()
    {
        // Arrange
        var phoneShop = new PhoneService();

        // Act
        bool actual = phoneShop.IsPhoneAvalable("Samsung", "Galaxy S21");

        // Assert
        Assert.That(actual, Is.True);
    }
}