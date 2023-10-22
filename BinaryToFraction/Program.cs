namespace BinaryToFraction
{
    internal class Program
    {
        public static void Main()
        {
            var questionBinary = "111001100110011001100111";
            var answerBinary = "11100110011001100110011";

            var questionFloat = ConvertBinaryFractionToFloat(questionBinary);
            Console.WriteLine($"The decimal representation of question is {questionFloat}");
            var answerFloat = ConvertBinaryFractionToFloat(answerBinary);
            Console.WriteLine($"The decimal representation of answer is {answerFloat}");
        }

        public static float ConvertBinaryFractionToFloat(string binaryFraction)
        {
            var floatValue = 0f;
            var divisor = 2f; // We start with dividing by 2 for the first bit after the point

            foreach (var bit in binaryFraction)
            {
                if (bit == '1')
                {
                    floatValue += 1 / divisor;
                    //Console.WriteLine(floatValue);
                }
                divisor *= 2;
            }

            return floatValue;
        }
    }
}
