using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    class Invoice
    {
        private readonly int account;
        private readonly string costumer, provider;

        private string article;
        private int quantity;

        public Invoice(int acc, string cos, string prov)
        {
            account = acc;
            costumer = cos;
            provider = prov;
        }

        public void Resol(string artic, int quan)
        {
            article = artic;
            quantity = quan;
            Console.WriteLine("Account: {0}", account);
            Console.WriteLine("Costumer: {0}", costumer);
            Console.WriteLine("Provider: {0}", provider);
            Console.WriteLine("Your summ: {0}", quan);
            switch (artic)
            {
                case "includeNds":
                    Console.WriteLine("Include nds"); 
                    Console.WriteLine("Summ with nds: {0}", quan);
                    Console.WriteLine("Summ without nds: {0}\n", quan - (quan * 18) / 100);
                    break;
                default:
                    Console.WriteLine("Not include nds");
                    Console.WriteLine("Summ with nds: {0}", quan + (quan * 18) / 100);
                    Console.WriteLine("Summ without nds: {0}\n", quan);
                    break;
            }
        }
    }
}
