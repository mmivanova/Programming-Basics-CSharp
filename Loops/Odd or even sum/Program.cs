using System;

namespace Odd_or_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddsum = 0;
            int evensum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0) evensum += number;
                else oddsum += number;
            }
            if (oddsum == evensum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddsum}"); 
            }
            else
            {
                int diff = Math.Abs(oddsum - evensum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
