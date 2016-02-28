using Ex.Secound.Classes.Task3Book;
using System;


namespace Ex.Secound.Classes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nikita's program");
            Presenter present = new Presenter();

            for(int i = 1; i < 9; i++)
            {
                present.ChooseAnExersize(i);
                Console.Clear();
            }
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
