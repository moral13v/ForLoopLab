using System;

namespace NumbersN1
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int n = int.Parse(Console.ReadLine());

            // condition

            for (int i = n; i >= 1 ; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
