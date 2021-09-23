using System;
using System.Collections.Generic;
using PhoneShop.Model;

namespace PhoneShop.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        public IEnumerable<Phone> GetAll() { throw new NotImplementedException(); }
        public Phone GetById(int id) { throw new NotImplementedException(); }
        public void Add(Phone phone) { throw new NotImplementedException(); }
        public void Edit(Phone phone) { throw new NotImplementedException(); }
        public void Delete(Phone phone) { throw new NotImplementedException(); }
    }
}
