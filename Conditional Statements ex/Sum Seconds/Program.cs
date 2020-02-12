using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsttime = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());
            int sum = firsttime + secondtime + thirdtime;
            int minutes = sum / 60;
            int seconds = sum % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
