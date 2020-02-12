using System;

namespace small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string product = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double pricecoffee = 0.0;        
            double pricewater = 0.0;        
            double pricebeer = 0.0;        
            double pricesweets = 0.0;        
            double pricepeanuts = 0.0;
            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        pricecoffee = 0.50;
                    }
                    else if (product == "water")
                    {
                        pricewater = 0.80;
                    }
                    else if (product == "beer")
                    {
                        pricebeer = 1.20;
                    }
                    else if (product == "sweets")
                    {
                        pricesweets = 1.45;
                    }
                    else if(product == "peanuts")
                    {
                        pricepeanuts = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        pricecoffee = 0.40;
                    }
                    else if (product == "water")
                    {
                        pricewater = 0.70;
                    }
                    else if (product == "beer")
                    {
                        pricebeer = 1.15;
                    }
                    else if (product == "sweets")
                    {
                        pricesweets = 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        pricepeanuts = 1.50;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        pricecoffee = 0.45;
                    }
                    else if (product == "water")
                    {
                        pricewater = 0.70;
                    }
                    else if (product == "beer")
                    {
                        pricebeer = 1.10;
                    }
                    else if (product == "sweets")
                    {
                        pricesweets = 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        pricepeanuts = 1.55;
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}
