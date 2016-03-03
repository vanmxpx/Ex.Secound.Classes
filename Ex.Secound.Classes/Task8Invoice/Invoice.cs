using System;

namespace Ex.Secound.Classes
{
    class Invoice
    {
        private readonly int account;
        private readonly string costumer, provider;

        private bool nds;
        private int quantity;

        public Invoice(int acc, string cos, string prov)
        {
            account = acc;
            costumer = cos;
            provider = prov;
        }

        public void Resol(bool nds, int quan)
        {
            this.nds = nds;
            quantity = quan;
            Console.WriteLine("Account: {0}", account);
            Console.WriteLine("Costumer: {0}", costumer);
            Console.WriteLine("Provider: {0}", provider);
            Console.WriteLine("Your summ: {0}", quan);
            if (nds)
            {
                Console.WriteLine("Include nds");
                Console.WriteLine("Summ with nds: {0}", quan);
                Console.WriteLine("Summ without nds: {0}\n", quan - (quan * 18) / 100);
            }
            else
            {
                Console.WriteLine("Not include nds");
                Console.WriteLine("Summ with nds: {0}", quan + (quan * 18) / 100);
                Console.WriteLine("Summ without nds: {0}\n", quan);
            }
        }
    }
}
