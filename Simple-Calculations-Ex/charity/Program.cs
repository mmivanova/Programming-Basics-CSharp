using System;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double cakesprice = cakes * 45;
            double wafflesprice = waffles * 5.80;
            double pancakesprice = pancakes * 3.20;
            double priceperday = (cakesprice + wafflesprice + pancakesprice) * chefs;
            double fullprice = priceperday * days;
            double expence = fullprice / 8;
            double income = fullprice - expence;
            Console.WriteLine($"{income:F2}");
        }
    }
}
