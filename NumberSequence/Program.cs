using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 

            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;



            // loop

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }



            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");


        
        }
    }
}
