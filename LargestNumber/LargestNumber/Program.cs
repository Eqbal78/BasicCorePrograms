using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;

            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("First is largest number : " + first);
            }
            else
            {
                if (second > first && second > third)
                {
                    Console.WriteLine("Second is largest number : " + second);

                }
                else
                {
                    Console.WriteLine("Third is largest number : " + third);
                }
            }
        }
    }
}
