﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes
{
    partial class Presenter
    {
        public void Inployee()
        {
            Inployee worker1 = new Inployee("Nikita", "Tsyhankov");
            Inployee worker2 = new Inployee("Rick", "Awsman");
            Inployee worker3 = new Inployee("Vitaly", "Hinder");

            worker1.Cash("c#", 1, "low");
            worker2.Cash("java", 2, "full");
            worker3.Cash("php", 3, "mid");

            worker1.Show();
            worker2.Show();
            worker3.Show();
        }
    }
}
