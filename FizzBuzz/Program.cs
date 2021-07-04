using System;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 100;
            int step = 15;
            string[] arrStr = new string[count];
            for (int i = 1; i <= count; ++i)
            {

                arrStr[i-1] = Convert.ToString(i);
                

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
                if(arrStr[i - 1].Equals("FizzBuzz")) { arrStr[i - 1] = $"\n  {arrStr[i - 1]}"; }
            }
            WriteLine(string.Join(", ", arrStr) + ".");

        }
    }
}
