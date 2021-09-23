using System.Linq;
using PhoneShop.Repositories;

namespace PhoneShop
{
    public class PhoneShop
    {
        private readonly PhoneRepository _phoneRepository = new();

        public bool IsPhoneAvalable(string brand, string model)
        {
            return _phoneRepository
                .GetAll()
                .Any(p => p.Brand == brand && p.Model == model && p.Count > 0);
        }
    }
}
