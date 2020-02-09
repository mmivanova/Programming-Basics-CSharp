using System;

namespace DanceStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double area = (lenght * 100) * (width * 100);
            double areawardrobe = (side * 100) * (side * 100);
            double areabench = area / 10;
            double freespace = area - areabench - areawardrobe;
            double dancers = freespace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
