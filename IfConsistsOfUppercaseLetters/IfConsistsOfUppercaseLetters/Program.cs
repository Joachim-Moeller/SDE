namespace IfConsistsOfUppercaseLetters
{
    class IfConsistsOfUppercaseLettersAssignment
    {
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write 3 characters to see if all are upppercase or not.");
            string first = Console.ReadLine();

            Console.Write(first + " is ");
            Console.WriteLine(IfConsistsOfUppercaseLetters(first));
            Console.Read();
        }
    }
}