using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int quantity = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < quantity; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = 0; i < quantity; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            int diff = Math.Abs(leftSum - rightSum);

            if (leftSum == rightSum )
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
