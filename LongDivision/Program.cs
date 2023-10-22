namespace LongDivision
{
    using System;
    using System.Text;

    class Program
    {
        static void LongDivision(int dividend, int divisor)
        {
            if (divisor == 0) throw new ArgumentException("Division by zero!");

            StringBuilder output = new StringBuilder();
            int carry = 0;
            int position = 0;
            string dividendStr = dividend.ToString();
            int result = 0;

            while (position < dividendStr.Length)
            {
                // Append the current digit from dividend to the carry.
                carry = carry * 10 + (dividendStr[position] - '0');
                position++;

                // How many times can the divisor be subtracted from the current carry?
                int currentResult = carry / divisor;
                result = result * 10 + currentResult;

                output.AppendLine($" {carry} | {divisor}");
                output.AppendLine($"-{currentResult * divisor}");
                output.AppendLine("__________");

                // Subtract the current amount from the carry.
                carry -= currentResult * divisor;
            }

            Console.WriteLine($"Long division of {dividend} by {divisor}:\n");
            Console.WriteLine(output.ToString());
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Remainder: {carry}");
        }

        static void Main()
        {
            Console.WriteLine("Enter the dividend:");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());

            LongDivision(dividend, divisor);
        }
    }
}
