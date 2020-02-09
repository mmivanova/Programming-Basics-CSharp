using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volume = lenght * width * height;
            double liters = volume * 0.001;
            double perc = percent * 0.01;
            double sum = liters * (1 - perc);
            Console.WriteLine($"{sum:F3}");
        }
    }
}
