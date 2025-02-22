using System;

namespace incomeTax
{
    class Program
    {
        static decimal GetNumber(string text)
        {
            decimal number;
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out number) && number > 0)
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
                decimal income = GetNumber("Please enter your Income [zł]: ");
                decimal tax = 0;

                if (income <= 85528)
                {
                    tax = income * 0.18m - 556.02m;
                }
                else
                {
                    tax = (income - 85528) * 0.32m + 14839.02m;
                }
                Console.WriteLine($"Your tax is: {tax:F2} zł");
                Console.Write("Do you want to calculate again? y/n: ");
                repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToLower(repeat) == 'y');
            Console.WriteLine("Goodbye.");
        }
    }
}