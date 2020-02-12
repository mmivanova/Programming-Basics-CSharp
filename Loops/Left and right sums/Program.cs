using System;

namespace Left_and_right_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumone = 0;
            for (int i = 1; i <= n; i++)
            {
                sumone = sumone + int.Parse(Console.ReadLine());
            }
            int sumtwo = 0;
            for (int i = 1; i <= n; i++)
            {
                sumtwo = sumtwo + int.Parse(Console.ReadLine());
            }
            if (sumone == sumtwo) Console.WriteLine("Yes, sum =" + sumone);
            else
            {
                int diff = Math.Abs(sumone - sumtwo);
                Console.WriteLine("No, diff =" + diff);
            }
            
        }
    }
}
