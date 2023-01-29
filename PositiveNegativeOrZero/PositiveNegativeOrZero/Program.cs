namespace PositiveNegativeOrZero
{
    class PositiveNegativeOrZeroAssignment
    {
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "positive.";
            }
            else if (num < 0.0)
            {
                return "egative.";
            }
            return "zero.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to see if it is positive, negative, or zero: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("The number entered is ");
            Console.WriteLine(PositiveNegativeOrZero(num));
            Console.ReadLine();
        }
    }
}