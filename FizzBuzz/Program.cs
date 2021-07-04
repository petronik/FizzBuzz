using System;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 100;
            string[] arrStr = new string[count];
            for (int i = 1; i <= count; ++i)
            {

                arrStr[i-1] = Convert.ToString(i);

                if((i - 1) % 15 == 0) { arrStr[i - 1] = $"\n  {arrStr[i - 1]}"; } // <--- OFFSET (i - 1)

                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    arrStr[i-1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    arrStr[i-1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    arrStr[i-1] = "Buzz";
                }
                
            }
            WriteLine(string.Join(", ", arrStr) + ".");

        }
    }
}
