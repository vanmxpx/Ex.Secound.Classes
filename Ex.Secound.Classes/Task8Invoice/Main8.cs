using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public static void Invoice()
        {
            Invoice acc1 = new Invoice(1, "First", "Trio");
            Invoice acc2 = new Invoice(2, "Second", "TSI");

            acc1.Resol("includeNds", 3000);
            acc2.Resol("dontIncludeNds", 4000);
        }
    }
}
