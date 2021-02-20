using System;

namespace Numbers1NStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int n = int.Parse(Console.ReadLine());

            // loop

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
