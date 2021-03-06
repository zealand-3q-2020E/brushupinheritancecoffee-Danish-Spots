﻿using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(0.5, "normal coffee beans"),
                new BlackCoffee(0.2, "normal coffee beans"),
                new Latte(0.1, "normal coffee beans"),
                new Amazonas(0.2, "A mixture of beans from the brazil and chile")

            };

            List<IMilk> coffeesWMilks = new List<IMilk>()
            {
                new Cortado(0.1, "normal coffee beans"),
                new Latte(0.2, "normal coffee beans")
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Strength of the {coffee.GetType().ToString()} is : "+ coffee.Strength());
                Console.WriteLine($"the Price of the {coffee.GetType().ToString()} is : " + coffee.price());
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
