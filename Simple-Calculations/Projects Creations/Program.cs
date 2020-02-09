using System;

namespace Projects_Creations
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            if (project > 100)
            {
                Console.WriteLine("Error!");
            }
            int hours = project * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {project} project/s.");
        }
    }
}
