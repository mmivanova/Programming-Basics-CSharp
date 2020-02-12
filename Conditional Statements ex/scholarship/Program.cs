using System;

namespace scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double attainment = double.Parse(Console.ReadLine());
            double minimalwage = double.Parse(Console.ReadLine());
            double socialscholarship = Math.Floor(minimalwage * 0.35);
            double attainmentscholarship = Math.Floor(attainment * 25);
            if (attainment >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {attainmentscholarship} BGN");
            }
            else if (income < minimalwage && attainment >= 5.50)
            {
                if (socialscholarship > attainmentscholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialscholarship} BGN");
                }
               // else if (socialscholarship == attainmentscholarship)
               // {
               //     Console.WriteLine($"You get a scholarship for excellent results {attainmentscholarship} BGN");
               // }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {attainmentscholarship} BGN");
                }
            }
            else if (income < minimalwage && attainment >= 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialscholarship} BGN");
            }
            else if (socialscholarship == attainmentscholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {attainmentscholarship} BGN");
                }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
