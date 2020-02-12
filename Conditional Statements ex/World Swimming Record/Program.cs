using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldrecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeforameter = double.Parse(Console.ReadLine());
            double ivanstime = distance * timeforameter;
            double delay = Math.Floor(distance / 15) * 12.5;
            double fulltime = ivanstime + delay;
            if (fulltime >= worldrecord)
            {
                Console.WriteLine($"No, he failed! He was {fulltime - worldrecord:F2} seconds slower.");
            }
            else if (fulltime < worldrecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fulltime:F2} seconds.");
            }
        }
    }
}
