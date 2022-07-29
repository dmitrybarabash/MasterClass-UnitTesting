using System;
using PhoneShop.Services;

namespace PhoneShop;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Phone Shop Tests Demo");

        var phoneService = new PhoneService();
        if (phoneService.IsPhoneAvalable("Samsung", "Galaxy S21"))
            Console.WriteLine("Gotcha!");
    }
}
