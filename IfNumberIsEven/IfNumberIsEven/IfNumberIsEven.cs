namespace IfNumberIsEven
{
    class IfNumberIsEvenAssignment
    {
        static bool IfNumberIsEven(int num)
        {
            return num % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Type a number to see if it is an even number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " as it pertains to being an even number is ");
            Console.WriteLine(IfNumberIsEven(num));
        }
    }
}