using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double arearectangle = tables * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double areasquare = tables * lenght / 2 * lenght / 2; 
            double usdprice = (arearectangle * 7) + (areasquare * 9);
            double bgnprice = usdprice * 1.85;
            Console.WriteLine($"{usdprice:F2} USD");
            Console.WriteLine($"{bgnprice:F2} BGN");
        }
    }
}
