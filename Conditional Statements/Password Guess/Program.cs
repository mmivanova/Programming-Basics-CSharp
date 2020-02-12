using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
           switch (pass)
            {
                case "s3cr3t!P@ssw0rd" :
                    Console.WriteLine("Welcome");
                    break;
                default:
                    Console.WriteLine("Wrong password!");
                    break;
            }
        }
    }
}
