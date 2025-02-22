using System;

namespace QuadraticEquation
{
    class Program
    {
        static double GetNumber(string text)
        {
            Console.WriteLine("Welcome to Quadratic equation calculator.");
            double number;
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    return number;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Value. Please try again!");
                Console.ResetColor();
            }
        }
        static void Main()
        {
            char repeat;
            do
            {
                double A = GetNumber("Please enter the value of number A: ");
                double B = GetNumber("Please enter the value of number B: ");
                double C = GetNumber("Please enter the value of number C: ");

                double delta = Math.Pow(B, 2) - 4 * A * C;

                if (delta > 0)
                {
                    double X1 = (- B - Math.Sqrt(delta)) / (2 * A);
                    double X2 = (- B + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine($"DELTA = {delta:F2} The solution to the equation is: X1 = {X1:F2} and X2 = {X2:F2}");
                }
                else if (delta == 0)
                {
                    double X = -B / (2 * A);
                    Console.WriteLine($"DELTA = 0, The solution to the equation is: X = {X:F2}");
                }
                else
                {
                    Console.WriteLine($"DELTA < 0, The equation has no solution");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to calculate another equation? y/n");
                repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.ResetColor();

            } while (char.ToLower(repeat) == 'y');

            Console.WriteLine("Goodbye.");
        }
    }
}