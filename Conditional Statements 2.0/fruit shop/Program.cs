﻿using System;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayofweek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0.0;
            switch (dayofweek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            break;
                        case "apple":
                            price = 1.20;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "kiwi":
                            price = 2.70;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "pineapple":
                            price = 5.50;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;

                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.90;
                            break;
                        case "kiwi":
                            price = 3.00;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            break;
                        case "pineapple":
                            price = 5.60;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;

                    }
                    break;
            }
            double finalprice = price * amount;
            if (finalprice == 0.0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{finalprice:F2}");
            }
        }
    }
}
