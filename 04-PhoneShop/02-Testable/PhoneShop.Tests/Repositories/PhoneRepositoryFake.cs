using System.Linq;
using System.Collections.Generic;
using PhoneShop.Model;
using PhoneShop.Repositories;

namespace PhoneShop.Tests.Repositories
{
    // Подделка репозитория для тестирования
    public class PhoneRepositoryFake : IPhoneRepository
    {
        private readonly List<Phone> _phones = new()
        {
            new Phone { Id = 1, Brand = "Samsung", Model = "Galaxy S20", Count = 3 },
            new Phone { Id = 2, Brand = "Samsung", Model = "Galaxy S21", Count = 5 },
            new Phone { Id = 3, Brand = "Apple", Model = "iPhone 13", Count = 4 },
            new Phone { Id = 4, Brand = "Xiaomi", Model = "Mi 11 Max", Count = 3 },
            new Phone { Id = 5, Brand = "Google", Model = "Pixel 4", Count = 2 }
        };

        public IEnumerable<Phone> GetAll() => _phones;

        public Phone GetById(int id) =>
            _phones.Where(p => p.Id == id).SingleOrDefault();

        public void Add(Phone phone) => _phones.Add(phone);

        public void Edit(Phone phone)
        {
            var phoneToEdit = GetById(phone.Id);
            if (phoneToEdit is not null)
            {
                phoneToEdit.Brand = phone.Brand;
                phoneToEdit.Model = phone.Model;
                phoneToEdit.Price = phone.Price;
                phoneToEdit.Count = phone.Count;
            }
        }

        public void Delete(Phone phone) => _phones.Remove(phone);
    }
}
