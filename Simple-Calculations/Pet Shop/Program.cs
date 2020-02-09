using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int minenum = int.Parse(Console.ReadLine());
            int neighboursnum = int.Parse(Console.ReadLine());
            double mineprice = 2.50;
            double neighboursprice = 4.00;
            if (minenum > 100 || neighboursnum > 100)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                double sum = (minenum * mineprice) + (neighboursnum * neighboursprice);
                Console.WriteLine($"{sum:F2} lv.");
            }
        }
    }
}
