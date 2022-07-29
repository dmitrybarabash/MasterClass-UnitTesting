using System.Linq;
using PhoneShop.Repositories;

namespace PhoneShop.Services;

// Наша полезная бизнес-логика, которую, собственно, и надо покрыть тестами
public class PhoneService
{
    // Создаем зависимость
    private readonly PhoneRepository _phoneRepository = new();

    public bool IsPhoneAvalable(string brand, string model) =>
        _phoneRepository
            .GetAll()                                                        // Использование внешней зависимости
            .Any(p => p.Brand == brand && p.Model == model && p.Count > 0);  // Наша бизнес-логика
}
