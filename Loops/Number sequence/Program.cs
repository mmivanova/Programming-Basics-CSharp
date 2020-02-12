using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < smallest) smallest = number;
                if (number > biggest) biggest = number;
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
