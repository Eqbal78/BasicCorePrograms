using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");

            Random Rand = new Random();

            int heads = 0;
            int tails = 0;
            Double percentage = 0;
            int result = 0;
            Console.WriteLine("Number of time flip coin");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                result = Rand.Next(0, 2);

                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }

            }
            Console.WriteLine("heads was flipped {0} times", heads);
            percentage = ((heads*100d) / num);
            Console.WriteLine("Percentage: " + percentage);
            Console.WriteLine("tails was flipped {0} times", tails);
            percentage = ((tails * 100d) / num);
            Console.WriteLine("Percentage: " + percentage);
        }
    }
}
