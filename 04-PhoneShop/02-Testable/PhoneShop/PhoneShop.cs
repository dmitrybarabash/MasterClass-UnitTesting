using System.Linq;
using PhoneShop.Repositories;

namespace PhoneShop
{
    public class PhoneShop
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneShop(IPhoneRepository phoneRepository) =>
            _phoneRepository = phoneRepository;

        public bool IsPhoneAvalable(string brand, string model)
        {
            return _phoneRepository
                .GetAll()
                .Any(p => p.Brand == brand && p.Model == model && p.Count > 0);
        }
    }
}
