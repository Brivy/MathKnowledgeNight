namespace GoldschmidtDivision
{
    using System;

    namespace GoldschmidtDivisionDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Define the numbers to be divided
                double A = 10;
                double D = 3;

                // Initial guess for 1/D
                double R = 0.1;

                Console.WriteLine($"Dividing {A} by {D} using the Goldschmidt method");
                Console.WriteLine($"Initial guess for 1/{D}: {R}");

                // Define the number of iterations
                int iterations = 10;

                for (int i = 1; i <= iterations; i++)
                {
                    R = R * (2 - D * R);
                    Console.WriteLine($"After iteration {i}, approximation for 1/{D} is: {R}");
                }

                double result = A * R;
                Console.WriteLine($"Approximated result for {A} ÷ {D} is: {result}");
                Console.WriteLine($"Actual result for {A} ÷ {D} is: {A / D}");
            }
        }
    }
}
