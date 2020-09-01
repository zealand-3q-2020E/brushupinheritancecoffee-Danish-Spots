using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {

        public BlackCoffee(double d) : base(d)
        {

        }

        public override string Strength()
        {
            return "Strong";
        }

        public override int price()
        {
            int price = 20;
            double dPrice = price * (1 - Discount);
            try
            {
                if (price - dPrice > 5)
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return Convert.ToInt32(dPrice);
        }
    }
}
