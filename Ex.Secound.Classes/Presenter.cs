using Ex.Secound.Classes.Task3Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public void ChooseAnExersize(int ex)
        {
            Console.WriteLine("Exersize #{0}", ex);
            switch (ex)
            {
                case 1:
                    Adress();
                    break;
                case 2:
                    Rectange();
                    break;
                case 3:
                    Book();
                    break;
                case 4:
                    Point();
                    break;
                case 5:
                    User();
                    break;
                case 6:
                    Converter();
                    break;
                case 7:
                    Inployee();
                    break;
                default:
                    Invoice();
                    break;
            }
            Console.WriteLine("Enter any key to go next exersize");
            Console.ReadLine();
        }
    }

}
