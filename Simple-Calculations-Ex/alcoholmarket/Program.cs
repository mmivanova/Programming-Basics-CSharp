using System;

namespace alcoholmarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyprice = double.Parse(Console.ReadLine());
            double beerlit = double.Parse(Console.ReadLine());
            double winelit = double.Parse(Console.ReadLine());
            double rakialit = double.Parse(Console.ReadLine());
            double whiskeylit = double.Parse(Console.ReadLine());
            double whiskeysum = whiskeyprice * whiskeylit;
            double rakiaprice = whiskeyprice / 2;
            double wineprice = rakiaprice - (0.4 * rakiaprice);     
            double beerprice = rakiaprice - (0.8 * rakiaprice);
            double rakiasum = rakiaprice * rakialit;
            double winesum = wineprice * winelit;
            double beersum = beerprice * beerlit;
            double fullprice = rakiasum + winesum + beersum + whiskeysum;
            Console.WriteLine($"{fullprice:F2}");
        }
    }
}
