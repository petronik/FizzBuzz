using System;
using static System.Console;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            try
            {
                WriteLine("Enter a number between 0 and 255:");
                a = Convert.ToInt32(ReadLine());
                WriteLine("Enter another number between 0 and 255:");
                b = Convert.ToInt32(ReadLine());
                if ((a < 0 || a > 255) || (b < 0 || b > 255))
                {
                    throw new ArgumentOutOfRangeException();
                }
                WriteLine($"{a} divided by {b} is {a / b}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine("ArgumentOutOfRangeException: " + e.Message);
            }
            catch (FormatException e)
            {
                WriteLine("FormatException: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                WriteLine("DivideByZeroException: " + e.Message);
            }
            catch (Exception e)
            {
                WriteLine("Exception: " + e.Message);
            }

            WriteLine("Have a nice day!!!");
        }
    }
}
