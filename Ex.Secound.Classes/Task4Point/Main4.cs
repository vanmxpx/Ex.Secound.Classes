namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Point()
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
    }
}
