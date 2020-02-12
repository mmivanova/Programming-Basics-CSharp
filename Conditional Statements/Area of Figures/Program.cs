using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double sidesquare = double.Parse(Console.ReadLine());
                double areasquare = sidesquare * sidesquare;
                Console.WriteLine($"{areasquare:F3}");
            }
            else if (figure == "rectangle")
            {
                double sidea = double.Parse(Console.ReadLine());
                double sideb = double.Parse(Console.ReadLine());
                double arearectanle = sidea * sideb;
                Console.WriteLine($"{arearectanle:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areacircle = Math.PI * radius * radius;
                Console.WriteLine($"{areacircle:F3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double areatriangle = side * height * 0.5;
                Console.WriteLine($"{areatriangle:F3}");
            }
        }
    }
}
