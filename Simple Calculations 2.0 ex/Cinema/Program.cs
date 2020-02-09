
using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double area = row * column;
            double income = 0.0;
            switch (type)
            {
                case "Premiere":
                    income = area * 12.00;
                    break;
                case "Normal":
                    income = area * 7.50;
                    break;
                case "Discount":
                    income = area * 5.00;
                    break;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
