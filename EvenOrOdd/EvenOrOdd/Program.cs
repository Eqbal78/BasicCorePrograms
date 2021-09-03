using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("It is an Even Number.");
            }
            else
            {
                Console.WriteLine("It is an Odd Number.");
            }
        }
    }
}
