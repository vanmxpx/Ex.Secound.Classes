using System;

namespace Ex.Secound.Classes
{
    class Inployee
    {
        private string name, lastname;
        private string developer;
        private double cash;
        public Inployee(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public double Cash(string developer, double years, string tax)
        {
            this.developer = developer;
            switch (developer)
            {
                case "java":
                    cash = 25000;
                    break;
                case "php":
                    cash = 20000;
                    break;
                case "c++":
                    cash = 27000;
                    break;
                default:
                    cash = 30000;
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
            Console.WriteLine("Developer:{0}", developer);
            Console.WriteLine("Salary:{0}\n", cash);
        }
    }
}
