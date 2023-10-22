using System.Text;

namespace FractionToBinary
{
    internal class Program
    {
        static void Main()
        {
            var maxIterations = 1000;
            var question = 1.2f - 0.3f;
            var answer = 0.9f;

            var questionResult = ConvertFractionToBinary(question, maxIterations);
            Console.WriteLine($"The question has a binary representation of: {questionResult}");
            var answerResult = ConvertFractionToBinary(answer, maxIterations);
            Console.WriteLine($"The answer has a binary representation of: {answerResult}");
        }

        private static string ConvertFractionToBinary(float value, int maxIterations)
        {
            var binaryRepresentation = new StringBuilder();
            for (var i = 0; i < maxIterations && value != 0.0f; i++)
            {
                value *= 2;
                if (value >= 1)
                {
                    binaryRepresentation.Append('1');
                    value -= 1;
                }
                else
                {
                    binaryRepresentation.Append('0');

                }
            }

            return binaryRepresentation.ToString();
        }
    }
}
