using System;

namespace BMI
{
    class Program
    {
        static double GetNumber(string text)
        {
            double number;
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Value. Try again!");
                Console.ResetColor();
            }
        }
        static void Main()
        {
            char repeat;

            do
            {
                double heigh = GetNumber("Please enter your heigh [m]: ");
                double weight = GetNumber("Please enter your weight [kg]: ");

                double BMI = weight / Math.Pow(heigh, 2);

                if (BMI < 18.5)
                {
                    Console.WriteLine($"You are underweight. Your BMI is {BMI:F2}");
                }
                else if (BMI > 24.9)
                {
                    Console.WriteLine($"You are overweight. Your BMI is {BMI:F2}");
                }
                else
                {
                    Console.WriteLine($"Your weight is correct. Your BMI is {BMI:F2}");
                }

                Console.WriteLine("Do you want to calculate BMI again? y/n: ");
                repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToLower(repeat) == 'y');

            Console.WriteLine("Goodbye.");
        }
    }
}