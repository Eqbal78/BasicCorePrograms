using System;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Swapping a = {0} b = {1}\n", a, b);
            int c = 0;
            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swapping a = {0} b = {1}", a, b);

        }
    }
}
