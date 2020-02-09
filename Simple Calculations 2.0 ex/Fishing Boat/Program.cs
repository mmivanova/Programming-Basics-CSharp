using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double priceboat = 0.0;
            double discount = 0.0;
            switch (season)
            {
                case "Spring":
                    priceboat = 3000;
                    if (fishermen <= 6)
                    {
                        discount = priceboat * 0.1;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        discount = priceboat * 0.15;
                    }
                    else if (12 < fishermen)
                    {
                        discount = 0.25;
                    }
                    break;
                case "Summer":
                    priceboat = 4200;
                    if (fishermen <= 6)
                    {
                        discount = priceboat * 0.1;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        discount = priceboat * 0.15;
                    }
                    else if (12 < fishermen)
                    {
                        discount = 0.25;
                    }
                    break;
                case "Autumn":
                    priceboat = 4200;
                    if (fishermen <= 6)
                    {
                        discount = priceboat * 0.1;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        discount = priceboat * 0.15;
                    }
                    else if (12 < fishermen)
                    {
                        discount = 0.25;
                    }
                    break;
                case "Winter":
                    priceboat = 2600;
                    if (fishermen <= 6)
                    {
                        discount = priceboat * 0.1;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        discount = priceboat * 0.15;
                    }
                    else if (12 < fishermen)
                    {
                        discount = 0.25;
                    }
                    break;
            }
            //double middleprice = priceboat - discount;
            double finalprice = 0.0;
            bool check = (season == "Autumn");
            if (fishermen % 2 == 0 && !check)
            {
                finalprice = priceboat - discount;
                finalprice = finalprice * 0.05;
                if (budget > finalprice)
                {
                    Console.WriteLine($"Yes! You have {budget - finalprice:F2} leva left!");
                }
                else if (finalprice > budget)
                {
                    Console.WriteLine($"Not enough money! You need {finalprice - budget:F2} leva.");
                }
            }
            else
            {
                finalprice = priceboat - discount;
                if (budget > finalprice)
                {
                    Console.WriteLine($"Yes! You have {budget + finalprice:F2} leva left!");
                }
                else if (finalprice > budget)
                {
                    Console.WriteLine($"Not enough money! You need {finalprice - budget:F2} leva.");
                }
            }
        }
    }
}
