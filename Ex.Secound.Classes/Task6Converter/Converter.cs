namespace Ex.Secound.Classes
{
    class Converter
    {
        private double toEUR, toUSD, toRUB;
        public Converter(double eu, double us, double ru)
        {
            toEUR = eu;
            toUSD = us;
            toRUB = ru;
        }

        public double UANtoEUR(double sum)
        {
            return sum / toEUR;
        }

        public double UANtoUSD(double sum)
        {
            return sum / toUSD;
        }

        public double UANtoRub(double sum)
        {
            return sum / toRUB;
        }

        public double EURtoUan(double sum)
        {
            return sum * toEUR;
        }
        public double USDtoUan(double sum)
        {
            return sum * toUSD;
        }
        public double RUBtoUan(double sum)
        {
            return sum * toRUB;
        }
    }
}
