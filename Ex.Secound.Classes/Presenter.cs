using Ex.Secound.Classes.Task3Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    class Presenter
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
                    break;
                case 7:
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to go next exersize");
            Console.ReadLine();
        }


        #region Exersises
        public void Adress()
        {
            Console.WriteLine("\t'Adress'");

            Adress adress = new Adress();

            adress.index = "49000";
            adress.country = "Ukraine";
            adress.city = "Dnipropetrovsk";
            adress.street = "Kirov";
            adress.house = 22;
            adress.apartment = 55;
            Console.Write("{0} {1} St., Apt. {2}, ", adress.house, adress.street, adress.apartment);
            Console.WriteLine("{0}, {1}, {2}", adress.city, adress.country, adress.index);

        }

        public void Rectange()
        {
            Console.WriteLine("\t'Rectandle'");

            double side1, side2;
            do
            {
                Console.Write("Enter first side:");
            }
            while (!Double.TryParse(Console.ReadLine(), out side1));

            do
            {
                Console.Write("Enter secound side:");
            }
            while (!Double.TryParse(Console.ReadLine(), out side2));

            Rectangle rect = new Rectangle(side1, side2);
            rect.AreaCalculator();
            rect.PerimeterCalculator();
            Console.WriteLine("Area: {0}, Perimeter: {1}.", rect.Area, rect.Perimeter);
        }

        public void Book()
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

        public void Point()
        {
            Point A = new Point(3, 5, "A");
            Point B = new Point(4, 4, "B");
            Point C = new Point(-4, -2, "C");
            Point D = new Point(1, 7, "D");
            Point E = new Point(2, -1, "E");

            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();
            triangle.ShowFigure();
            Figure rectangle = new Figure(A, B, C, D);
            rectangle.PerimeterCalculator();
            rectangle.ShowFigure();
            Figure pentagon = new Figure(A, B, C, D, E);
            pentagon.PerimeterCalculator();
            pentagon.ShowFigure();
        }

        public void User()
        {
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
        #endregion
    }

}
