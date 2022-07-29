using System.Collections.Generic;
using PhoneShop.Models;

namespace PhoneShop.Repositories;

public interface IPhoneRepository
{
    IEnumerable<Phone> GetAll();
    Phone GetById(int id);
    void Add(Phone phone);
    void Edit(Phone phone);
    void Delete(Phone phone);
}