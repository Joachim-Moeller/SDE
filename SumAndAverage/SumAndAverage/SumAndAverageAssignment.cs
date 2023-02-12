namespace SumAndAverage
{
    internal class SumAndAverageAssignment
    {
        static string SumAndAverage(int a, int b)
        {
            int sum = 0;
            double range = 0;
            double average = 0.0;

            for (int i = a; i <= b; i++)
            {
                sum += i;
                range++;
            }
            average = sum / range;

            return string.Format($"The sum is {sum} and the average is {average}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers to get the sum of all integers and the average of their range");
            Console.Write("Enter lowest integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter highest integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumAndAverage(a, b));
            Console.ReadLine();
        }
    }
}