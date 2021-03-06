using System;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; ++i)
            {
                if (i == 100)
                {
                    Console.Write($"{i}.");
                }
                else
                {
                    if ((i % 5) == 0 && (i % 3) == 0)
                    {
                        Console.Write("FizzBuzz, ");
                    }
                    else if ((i % 3 == 0))
                    {
                        Console.Write("Fizz, ");
                    }
                    else if ((i % 5 == 0))
                    {
                        Console.Write("Buzz, ");
                    }
                    else
                        Console.Write($"{i}, ");
                }
                if (i % 15 == 0) WriteLine();
            }

        }
    }
}