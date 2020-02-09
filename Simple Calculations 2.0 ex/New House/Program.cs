using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
            double discount = 0.0;
            double raise = 0.0;
            double finalprice = 0.0;
            switch (flower)
            {
                case "Roses":
                    price = 5.00;
                    if (number > 80)
                    {
                        discount = price * number * 0.1;
                        finalprice = (price * number) - discount;
                    }
                    else
                    {
                        finalprice = price * number;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (number > 90)
                    {
                        discount = price * number * 0.15;
                        finalprice = (price * number) - discount;
                    }
                    else
                    {
                        finalprice = price * number;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (number > 80)
                    {
                        discount = price * number * 0.15;
                        finalprice = (price * number) - discount;
                    }
                    else
                    {
                        finalprice = price * number;
                    }
                    break;
                case "Narcissus":
                    price = 3.00;
                    if (number < 120)
                    {
                        raise = price * number * 0.15;
                        finalprice = (price * number) + raise;
                    }
                    else
                    {
                        finalprice = price * number;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if ( number < 80)
                    {
                        raise = price * number * 0.2;
                        finalprice = (price * number) + raise;
                    }
                    else
                    {
                        finalprice = price * number;
                    }
                    break;
            }
            if (finalprice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {budget - finalprice :F2} leva left.");
            }
            else if (finalprice > budget)
            {
                Console.WriteLine($"Not enough money, you need {finalprice - budget :F2} leva more.");
            }
        }
    }
}
