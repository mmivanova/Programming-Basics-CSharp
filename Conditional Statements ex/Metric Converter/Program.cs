using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            switch (first)
            {
                case "mm":
                    if (second == "cm")
                    {
                        num = num * 0.1;
                    }
                    else if (second == "m")
                    {
                        num = num * 0.001;
                    }
                    break;
                case "cm":
                    if (second == "mm")
                    {
                        num = num * 10;
                    }
                    else if (second == "m")
                    {
                        num = num * 0.01;
                    }
                    break;
                case "m":
                    if (second == "mm")
                    {
                        num = num * 1000;
                    }
                    else if (second == "cm")
                    {
                        num = num * 100;
                    }
                    break;
            }
            Console.WriteLine($"{num:F3}");
        }
    }
}
