using System;

namespace loanInstallment
{
    class Program
    {
        static decimal GetNumber(string text, int min, int max)
        {
            decimal number;
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out number) && number >= min && number <= max)
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
                decimal loan = GetNumber("Please enter the loan amount from 100 to 10000$: ", 100, 10000);
                decimal numberInstallment = GetNumber(" please enter number of installment from 6 to 48: ", 6, 48);
                decimal installment;

                if (numberInstallment <= 12)
                {
                    installment = (loan * 1.025m) / numberInstallment;
                }
                else if (numberInstallment > 12 && numberInstallment > 24)
                {
                    installment = (loan * 1.1m) / numberInstallment;
                }
                else
                {
                    installment = (loan * 1.05m) / numberInstallment;
                }
                decimal totalCost = installment * numberInstallment;
                Console.WriteLine("Loan amount: " + loan + " $");
                Console.WriteLine("Number of installments: " + numberInstallment);
                Console.WriteLine($"Installment amout: {installment:F2} $");
                Console.WriteLine($"Total Loan cost: {totalCost:F2} $");

                Console.Write("Do you want to calculate again? y/n: ");
                repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToLower(repeat) == 'y');

            Console.WriteLine("Goodbye");
        }
    }
}
