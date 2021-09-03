using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Dividend ");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor ");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
