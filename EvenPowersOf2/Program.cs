using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int n = int.Parse(Console.ReadLine());

            // loop

            for (int power = 0; power <= n; power += 2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}
