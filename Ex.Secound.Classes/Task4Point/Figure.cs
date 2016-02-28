using System;
using System.Collections.Generic;

namespace Ex.Secound.Classes
{
    class Figure
    {
        private List<Point> points =  new List<Point>();
        public double Perimeter { get; set; } 

        public Figure(Point A, Point B, Point C)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
            points.Add(E);
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            for(int i = 0; i < points.Count - 2; i++)
            {
                Perimeter += LengthSide(points[i], points[i + 1]);
            }
            Perimeter += LengthSide(points[0], points[points.Count-1]);
        }

        public void ShowFigure()
        {
            Console.Write("Fiure: ");
            foreach (var point in points)
            {
                Console.Write(point.Name);
            }
            Console.WriteLine("\nPerimeter: {0}", Perimeter);
        }
    }
}
