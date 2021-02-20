using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string input = Console.ReadLine();

            // loop

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }
        }
    }
}
