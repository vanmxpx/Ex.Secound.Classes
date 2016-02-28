using System;

namespace Ex.Secound.Classes.Task3Book
{
    class Title
    {
        private string title;

        public void SetTitle(string value)
        {
            title = value;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
