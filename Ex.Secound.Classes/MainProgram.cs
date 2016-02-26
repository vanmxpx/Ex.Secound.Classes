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

            #region Test task 6
            Console.WriteLine("Ex. 6: Converter");



            Console.WriteLine("Press any key to go next exersize");
            Console.Read();
            #endregion

            #region Test task 7
            Console.WriteLine("Ex. 7: Inployee");



            Console.WriteLine("Press any key to go next exersize");
            Console.Read();
            #endregion

            #region Test task 8
            Console.WriteLine("Ex. 8: Invoice");



            Console.WriteLine("Press any key to go next exersize");
            Console.Read();
            #endregion
        }
    }
}
