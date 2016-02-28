using System;

namespace Ex.Secound.Classes.Task3Book
{
    class Content
    {
        private string content;

        public void SetContent(string value)
        {
            content = value;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}", content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
