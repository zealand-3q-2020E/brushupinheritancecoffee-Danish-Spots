using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public override string Strength()
        {
            return "Strong";
        }
    }
}
