using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes.Task3Book
{
    class Author
    {
        public string author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
