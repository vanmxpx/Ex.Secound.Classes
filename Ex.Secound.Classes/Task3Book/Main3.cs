using Ex.Secound.Classes.Task3Book;
using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Book()
        {
            Console.WriteLine("\t'Book'");

            Book mybook = new Book();
            Console.Write("Enter name of your book: ");
            mybook.SetTitle(Console.ReadLine());
            Console.Write("Enter author of your book: ");
            mybook.SetAuthor(Console.ReadLine());
            Console.Write("Enter content of your book: ");
            mybook.SetContent(Console.ReadLine());
            mybook.ShowAll();
        }
    }
}
