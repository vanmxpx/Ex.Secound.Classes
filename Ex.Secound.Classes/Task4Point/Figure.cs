using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    class Figure
    {
        Point A, B, C, D, E;
        private int sides;
        public double Perimeter { get; set; } 

        public Figure(Point A, Point B, Point C)
        {
            sides = 3;
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            sides = 4;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            sides = 5;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }

        public double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            return length;
        }

        public void PerimeterCalculator()
        {
            switch (sides)
            {
                case 3:
                    Perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A);
                    break;
                case 4:
                    Perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A);
                    break;
                default:
                    Perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
                    break;
            }
        }

        public void ShowFigure()
        {
            switch (sides)
            {
                case 3:
                    Console.WriteLine("Figure {0}{1}{2}", A.Name, B.Name, C.Name);
                    break;
                case 4:
                    Console.WriteLine("Figure {0}{1}{2}{3}", A.Name, B.Name, C.Name, D.Name);
                    break;
                default:
                    Console.WriteLine("Figure {0}{1}{2}{3}{4}", A.Name, B.Name, C.Name, D.Name, E.Name);
                    break;
            }
            Console.WriteLine("Perimeter: {0}", Perimeter);
        }
    }
}
