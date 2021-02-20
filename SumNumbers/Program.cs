using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int quantity = int.Parse(Console.ReadLine());
            int sum = 0;

            // loop


            for (int i = 1; i <= quantity; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }

            Console.WriteLine(sum);


        }
    }
}
