using System;

namespace number_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("No");
            }
            else if (-100 <= number && number <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
