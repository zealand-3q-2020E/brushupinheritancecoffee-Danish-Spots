using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(double d) : base(d)
        {
            
        }

        public override int price()
        {
            int price = 25;
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
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }
}
