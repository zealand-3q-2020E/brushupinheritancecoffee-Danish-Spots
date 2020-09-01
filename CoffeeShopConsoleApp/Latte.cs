using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {

        public Latte(double d) : base(d)
        {

        }

        public override int price()
        {
            int price = 40;
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

        public override string Strength()
        {
            return "Weak";
        }


        public int mlMilk()
        {
            return 200;
        }
    }
}
