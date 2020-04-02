using System;

namespace Half_Sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max) max = number;
            }
            int sumtocheck = sum - max;
            if (sumtocheck == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumtocheck);
            }
            else
            {
                int diff = Math.Abs(sumtocheck - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
