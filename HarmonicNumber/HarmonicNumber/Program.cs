using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            float s = 0;

            Console.Write("Input the number of terms : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 /(float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1}\n ", n, s);
        }
    }
}
