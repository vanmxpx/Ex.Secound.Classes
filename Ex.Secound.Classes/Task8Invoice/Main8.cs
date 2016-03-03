namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Invoice()
        {
            Invoice acc1 = new Invoice(1, "First", "Trio");
            Invoice acc2 = new Invoice(2, "Second", "TSI");

            acc1.Resol(true, 3000);
            acc2.Resol(false, 4000);
        }
    }
}
