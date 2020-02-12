using System;

namespace N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
