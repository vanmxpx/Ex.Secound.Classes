namespace Ex.Secound.Classes
{
    class Rectangle
    {
        private double side1, side2;
        private double area, perimeter;
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public void AreaCalculator()
        {
            area = side1 * side2;
        }

        public void PerimeterCalculator()
        {
            perimeter = 2 * (side1 + side2);
        }
    }
}
