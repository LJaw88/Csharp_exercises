using System;
using System.Diagnostics.CodeAnalysis;

namespace ATM
{
    class Program
    {
        static int GetPIN(string text)
        {
            int number;
            int PIN = 1234;
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number == PIN )
                {
                    return number;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid PIN. Please try again!");
                Console.ResetColor();
            }
        }
        static void Main()
        {
            Console.WriteLine("Welcome to Bank of England");
            int userPIN = GetPIN("Please enter your PIN number: ");
            int balance = 5000;
            char check;
            Console.WriteLine("Your PIN is correct. What do you want to do?");
            do
            {
                Console.WriteLine("Withdraw - press 1: ");
                Console.WriteLine("Deposit - press 2: ");
                Console.WriteLine("Check balance  - press 3: ");
                Console.WriteLine("Exit - press 4: ");

                check = Console.ReadKey().KeyChar;
                Console.WriteLine();

                int sum = 0;

                if (check == '1')
                {
                    Console.WriteLine("How much do you want to withdraw?: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    if (sum > balance)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Account balance is to low!");
                        Console.ResetColor();
                    }
                    else
                    {
                        balance -= sum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You withdrew {sum} $. Your new account balance is {balance} $");
                        Console.ResetColor();
                    }
                }
                else if (check == '2')
                {
                    Console.WriteLine("How much do you want to deposit?: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    balance += sum;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You deposited {sum} $. Your new account balance is {balance} $");
                    Console.ResetColor();
                }
                else if (check == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your account balance is: " + balance + " $");
                    Console.ResetColor();
                }
                else if (check == '4')
                {
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choise. Please try again.");
                    Console.ResetColor();
                }
            } while (check != '4');
        }
    }
}