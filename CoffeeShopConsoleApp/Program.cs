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
                new Cortado(),
                new BlackCoffee(),
                new Latte()

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
