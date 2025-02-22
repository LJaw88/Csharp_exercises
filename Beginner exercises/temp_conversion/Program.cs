using System;

namespace temperatureConversion
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
                if (double.TryParse(input, out number))
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
            double Celsius = GetNumber("Please enter the temperature in degrees Celsius: ");
            double Fahrenheit = 1.8 * Celsius + 32.0;

            Console.WriteLine($"The temperature in degrees Fahrenheit is: {Fahrenheit:F2}");
        }
    }
}