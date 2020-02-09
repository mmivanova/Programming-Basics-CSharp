using System;

namespace Yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvmetri = double.Parse(Console.ReadLine());
            double fullprice = kvmetri * 7.61;
            double discount = 0.18 * fullprice;
            double finalprice = fullprice - discount;
            Console.WriteLine($"The final price is: {finalprice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
