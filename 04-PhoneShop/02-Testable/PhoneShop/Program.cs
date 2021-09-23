using System;
using PhoneShop.Repositories;

namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Shop Tests Demo");

            var phoneShop = new PhoneShop(new PhoneRepository());
            if (phoneShop.IsPhoneAvalable("Samsung", "Galaxy S21"))
                Console.WriteLine("Gotcha!");
        }
    }
}
