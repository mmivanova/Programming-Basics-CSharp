using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degrees = radian * (180 / Math.PI);
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
