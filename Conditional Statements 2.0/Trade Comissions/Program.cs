using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double smallcomission = 0.0;
            double averagecomission = 0.0;
            double bigcomission = 0.0;
            double hugecomission = 0.0;
            switch (city)
            {
                case "Sofia":
                    smallcomission = 0.05;
                    averagecomission = 0.07;
                    bigcomission = 0.08;
                    hugecomission = 0.12;
                    break;
                case "Plovdiv":
                    smallcomission = 0.055;
                    averagecomission = 0.08;
                    bigcomission = 0.12;
                    hugecomission = 0.145;
                    break;
                case "Varna":
                    smallcomission = 0.045;
                    averagecomission = 0.075;
                    bigcomission = 0.1;
                    hugecomission = 0.13;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (0 <= sales && sales <=500)
            {
                Console.WriteLine($"{smallcomission* sales :F2}");
            }
            else if (500 < sales && sales <= 1000)
            {
                Console.WriteLine($"{averagecomission * sales:F2}");
            }
            else if (1000 < sales && sales <= 10000)
            {
                Console.WriteLine($"{bigcomission * sales:F2}");
            }
            else if (10000 < sales)
            {
                Console.WriteLine($"{hugecomission * sales:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
