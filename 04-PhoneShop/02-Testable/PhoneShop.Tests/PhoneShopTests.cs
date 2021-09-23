using NUnit.Framework;
using PhoneShop.Tests.Repositories;

namespace PhoneShop.Tests
{
    public class PhoneShopTests
    {
        [Test]
        public void IsPhoneAvalable_Should_ReturnTrue_When_BrandIsSamsungAndModelIsGalaxyS21()
        {
            var phoneShop = new PhoneShop(new PhoneRepositoryFake());

            bool actual = phoneShop.IsPhoneAvalable("Samsung", "Galaxy S21");

            Assert.That(actual, Is.True);
        }
    }
}