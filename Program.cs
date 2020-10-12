using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            string cont = "y";

            while (cont.ToLower() == "y")
            {
                Console.WriteLine("Enter Length:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height:");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"Area: {length * width}");

                Console.WriteLine($"Perimeter: {2* (length + width)}");

                Console.WriteLine($"Volume: {length * width * height}");

                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Have a great day!");
        }
    }
}
