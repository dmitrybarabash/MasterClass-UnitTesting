using System;
using System.Linq;
using PhoneShop.Repositories;

namespace PhoneShop.Services;

// Наша полезная бизнес-логика, которую, собственно, и надо покрыть тестами
public class PhoneService
{
    // Тут теперь интерфейсная ссылка на зависимость
    private readonly IPhoneRepository _phoneRepository;

    // А саму зависимость внедряем через конструктор посредством Dependency Injection
    public PhoneService(IPhoneRepository phoneRepository) =>
        _phoneRepository = phoneRepository ?? throw new ArgumentNullException(nameof(phoneRepository));

    public bool IsPhoneAvalable(string brand, string model) =>
        _phoneRepository
            .GetAll()                                                        // Использование внешней зависимости
            .Any(p => p.Brand == brand && p.Model == model && p.Count > 0);  // Наша бизнес-логика
}
