using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes.Task3Book
{
    class Content
    {
        public string content;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}", content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
