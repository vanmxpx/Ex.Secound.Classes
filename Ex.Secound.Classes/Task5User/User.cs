using System;

namespace Ex.Secound.Classes
{
    class User
    {
        readonly private DateTime registration;

        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User(DateTime today)
        {
            registration = today;
        }

        public void Show()
        {
            Console.WriteLine("Acc created: {0}", registration.ToString("D"));
            Console.WriteLine("{0}: {1} {2}", Login, Name, LastName);
            Console.WriteLine("{0} age old.", Age);
        }
    }
}
