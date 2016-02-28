using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Adress()
        {
            Console.WriteLine("\t'Adress'");

            Adress adress = new Adress();

            adress.index = "49000";
            adress.country = "Ukraine";
            adress.city = "Dnipropetrovsk";
            adress.street = "Kirov";
            adress.house = 22;
            adress.apartment = 55;
            Console.Write("{0} {1} St., Apt. {2}, ", adress.house, adress.street, adress.apartment);
            Console.WriteLine("{0}, {1}, {2}", adress.city, adress.country, adress.index);

        }
    }
}
