using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Converter()
        {
            Converter conv = new Classes.Converter(30.2, 27.4, 0.36);
            Console.WriteLine("Enter your sum:");
            Console.Write("==> ");
            double sum = 0;
            while (!Double.TryParse(Console.ReadLine(), out sum) || sum < 0)
            {
                Console.WriteLine("Wrong! Try another");
            }
            Console.WriteLine("Uan ==> Euro: {0}", conv.EURtoUan(sum));
            Console.WriteLine("Uan ==> Dollar: {0}", conv.EURtoUan(sum));
            Console.WriteLine("Uan ==> Rub: {0}", conv.EURtoUan(sum));
            Console.WriteLine("Euro ==> Uan: {0}", conv.EURtoUan(sum));
            Console.WriteLine("Dollar ==> Uan: {0}", conv.USDtoUan(sum));
            Console.WriteLine("Rub ==> Uan: {0}", conv.RUBtoUan(sum));
        }
    }
}
