﻿using System;

namespace VowelSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string input = Console.ReadLine();

            //буква	      a	  e	  i	  o	  u
            //стойност    1   2   3   4   5

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];

                switch (currentLetter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }


            }

            Console.WriteLine(sum);
        }
    }
}
