using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Amazonas : Coffee
    {
        public Amazonas(double discount, string blend) : base(discount, blend)
        {
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
