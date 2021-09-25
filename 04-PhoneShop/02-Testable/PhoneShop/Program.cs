using System;
using PhoneShop.Repositories;

namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Shop Tests Demo");

            var phoneService = new PhoneService(new PhoneRepository());
            if (phoneService.IsPhoneAvalable("Samsung", "Galaxy S21"))
                Console.WriteLine("Gotcha!");
        }
    }
}
