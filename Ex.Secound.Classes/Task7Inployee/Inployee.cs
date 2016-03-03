using System;

namespace Ex.Secound.Classes
{
    enum Developer
    {
        Java, PHP, CPluc, CCharp 
    }
    class Inployee
    {
        private Developer dev;
        private string name, lastname;
        private double cash;
        public Inployee(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public double Cash(Developer dev, double years, string tax)
        {
            this.dev = dev;
            switch (dev)
            {
                case Developer.Java:
                    cash = 25000;
                    break;
                case Developer.PHP:
                    cash = 20000;
                    break;
                case Developer.CPluc:
                    cash = 27000;
                    break;
                case Developer.CCharp:
                    cash = 30000;
                    break;
                default:
                    Console.WriteLine("Not a developer.");
                    break;
            }
            switch (tax)
            {
                case "full":
                    cash -= 2000;
                    break;
                case "mid":
                    cash -= 1500;
                    break;
                case "low":
                    cash -= 500;
                    break;
                default:
                    cash -= 1000;
                    break;
            }
            return cash;
        }

        public void Show()
        {
            Console.WriteLine("Name:{0} {1}", name, lastname);
            Console.WriteLine("Developer:{0}", dev);
            Console.WriteLine("Salary:{0}\n", cash);
        }
    }
}
