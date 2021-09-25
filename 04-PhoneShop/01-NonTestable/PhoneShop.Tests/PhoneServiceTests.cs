using NUnit.Framework;

namespace PhoneShop.Tests
{
    public class PhoneServiceTests
    {
        [Test]
        public void IsPhoneAvalable_Should_ReturnTrue_When_BrandIsSamsungAndModelIsGalaxyS21()
        {
            var phoneShop = new PhoneService();

            bool actual = phoneShop.IsPhoneAvalable("Samsung", "Galaxy S21");

            Assert.That(actual, Is.True);
        }
    }
}