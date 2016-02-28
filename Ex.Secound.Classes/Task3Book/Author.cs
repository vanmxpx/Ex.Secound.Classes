using System;

namespace Ex.Secound.Classes.Task3Book
{
    class Author
    {
        private string author;

        public void SetAuthor(string value)
        {
            author = value;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
