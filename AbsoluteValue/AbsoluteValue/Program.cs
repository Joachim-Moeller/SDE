namespace AbsoluteValue
{
    internal class AbsoluteValue
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number to get its absolute value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Abs(a);
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Math.Abs(a);
            Console.Write("The absolute value of " + a + " is ");
            Console.Write(b);
            Console.ReadLine();
        }
    }
}
