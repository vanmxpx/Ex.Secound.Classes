using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Adress()
        {
            Console.WriteLine("\t'Adress'");

            Adress adress = new Adress();

            adress.Index = "49000";
            adress.Country = "Ukraine";
            adress.City = "Dnipropetrovsk";
            adress.Street = "Kirov";
            adress.House = 22;
            adress.Apartment = 55;
            Console.Write("{0} {1} St., Apt. {2}, ", adress.House, adress.Street, adress.Apartment);
            Console.WriteLine("{0}, {1}, {2}", adress.City, adress.Country, adress.Index);

        }
    }
}
