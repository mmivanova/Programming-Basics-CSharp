using System;

namespace King_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int walkerons = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());
            double scenery = budget * 0.1;
            if (walkerons > 150)
            {
                priceClothes = priceClothes - (priceClothes * 0.1);
            }
            double totalpriceclothes = walkerons * priceClothes;
            double totalprice = scenery + totalpriceclothes;
            if (totalprice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalprice - budget:F2} leva more.");
            }
            else if (totalprice <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalprice :F2} leva left.");
            }
        }
    }
}
