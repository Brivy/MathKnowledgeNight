namespace LongDivisionBinary
{
    using System;

    namespace MultiplicationVsDivision
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter two positive integers for demonstration:");
                Console.Write("First integer (for multiplication and divisor for division): ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Second integer (for multiplication and dividend for division): ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\n--- Multiplication ---");
                MultiplyVisual(num1, num2);

                Console.WriteLine("\n--- Division ---");
                DivideVisual(num2, num1);

                Console.ReadLine();
            }

            static void MultiplyVisual(int a, int b)
            {
                Console.WriteLine($"{a} x {b} is equivalent to adding {a} to itself {b} times.");
                int result = 0;
                for (int i = 1; i <= b; i++)
                {
                    result += a;
                    Console.WriteLine($"Step {i}: {a} x {i} = {result}");
                }
            }

            static void DivideVisual(int dividend, int divisor)
            {
                Console.WriteLine($"Dividing {dividend} by {divisor} involves subtracting {divisor} repeatedly from {dividend}.");

                int quotient = 0;
                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    quotient++;
                    Console.WriteLine($"Step {quotient}: Remaining value = {dividend}");
                }

                Console.WriteLine($"Quotient: {quotient}");
                Console.WriteLine($"Remainder: {dividend}");
            }
        }
    }

}
