using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Double num = 0;

            for (int i=1; i<=n; i++)
            {
                num = Math.Pow(i, 2);
                Console.WriteLine("Power of " +i+ " is: " +num);
            }
          
        }
    }
}
