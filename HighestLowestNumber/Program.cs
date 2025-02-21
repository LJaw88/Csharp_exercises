using System;
using System.Diagnostics.Contracts;

namespace HighestLowestNumber
{
    class Program
    {
        static int GetNumber(string text)
        {
            int number;
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    return number;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Value. Try Again!");
                Console.ResetColor();
            }
        }
        static void Main()
        {
            char repeat;

            do
            {
                int A = GetNumber("Please enter value of number A: ");
                int B = GetNumber("Please enter value of number B: ");
                int C = GetNumber("Please enter value of number C: ");
                int D = GetNumber("Please enter value of number D: ");
                int E = GetNumber("Please enter value of number E: ");

                int[] table = { A, B, C, D, E };

                int max = table.Max();
                int min = table.Min();

                Console.WriteLine("Max number is: " + max);
                Console.WriteLine("Min number is: " + min);

                Console.WriteLine("Do you want to check yur numbers again? y/n: ");
                repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToLower(repeat) == 'y');
            Console.WriteLine("Goodbye.");
        }
    }
}