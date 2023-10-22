namespace Division
{
    using System;

    class Program
    {
        static (int, int) Divide(int N, int D)
        {
            if (D == 0) throw new ArgumentException("Division by zero!");

            if (D < 0)
            {
                var (Q, R) = Divide(N, -D);
                return (-Q, R);
            }

            if (N < 0)
            {
                var (Q, R) = Divide(-N, D);
                if (R == 0)
                    return (-Q, 0);
                else
                    return (-Q - 1, D - R);
            }

            return DivideUnsigned(N, D);
        }

        static (int, int) DivideUnsigned(int N, int D)
        {
            int Q = 0;
            int R = N;

            Console.WriteLine($"Start with dividend (represented by '*'): {new string('*', R)}");

            while (R >= D)
            {
                R -= D;
                Q++;

                Console.WriteLine($"After subtracting {D}, remaining dividend: {new string('*', R)}");
            }

            return (Q, R);
        }

        static void Main()
        {
            Console.WriteLine("Enter the dividend (N):");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor (D):");
            int D = int.Parse(Console.ReadLine());

            var (Q, R) = Divide(N, D);

            Console.WriteLine($"\nResult of dividing {N} by {D}:");
            Console.WriteLine($"Quotient (Q) = {Q}");
            Console.WriteLine($"Remainder (R) = {R}");
        }
    }


}
