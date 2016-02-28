using System;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Rectange()
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
    }
}
