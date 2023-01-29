namespace IfYearIsLeap
{
    class IfYearIsLeapAssignment
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Type a year to see if it is a leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write(year + " being a leap year is ");
            Console.WriteLine(IfYearIsLeap(year));
        }
    }
}