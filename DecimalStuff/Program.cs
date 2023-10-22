namespace DecimalStuff
{
    internal class Program
    {
        static void Main()
        {
            var decimalTest = 123.456m;
            var decimalArray = decimal.GetBits(decimalTest);
            foreach (var i in decimalArray)
            {
                Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
            }
        }
    }
}
