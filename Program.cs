using System;

namespace BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the BasicMaths class
            BasicMaths math = new BasicMaths();

            // Demonstrate Add method
            double addResult = math.Add(10, 20);
            Console.WriteLine($"Addition: 10 + 20 = {addResult}");

            // Demonstrate Subtract method
            double subtractResult = math.Subtract(50, 15);
            Console.WriteLine($"Subtraction: 50 - 15 = {subtractResult}");

            // Demonstrate Multiply method
            double multiplyResult = math.Multiply(8, 9);
            Console.WriteLine($"Multiplication: 8 * 9 = {multiplyResult}");

            // Demonstrate Divide method
            try
            {
                double divideResult = math.Divide(100, 25);
                Console.WriteLine($"Division: 100 / 25 = {divideResult}");

                // Demonstrate divide by zero
                double divideByZeroResult = math.Divide(100, 0);
                Console.WriteLine($"Division by Zero: 100 / 0 = {divideByZeroResult}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
