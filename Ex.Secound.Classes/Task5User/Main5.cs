using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void User()
        {
            Console.WriteLine("Ex. 5: User");

            User user = new User(DateTime.Today);

            user.Login = "vanmxpx";
            user.Name = "Nikita";
            user.LastName = "Tsyhankov";
            user.Age = 19;

            user.Show();
        }
    }
}
