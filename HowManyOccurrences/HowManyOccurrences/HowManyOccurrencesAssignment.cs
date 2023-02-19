namespace HowManyOccurrences
{
    internal class HowManyOccurrencesAssignment
    {
        private static int HowManyOccurrences(string str, string subStr)
        {
            int found;
            var total = 0;
            for (var i = 0; i < str.Length; i++)
            {
                found = str.IndexOf(subStr, i);

                if (found > -1)
                {
                    total++;
                    i = found;
                }
            }

            return total;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput string and substring to get number of occurrences of substring in string.\n");
            Console.Write("Input string: ");
            var str = Console.ReadLine();
            Console.Write("Input substring: ");
            var subStr = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Number of occurrences of substring in string is ");
            Console.WriteLine(HowManyOccurrences(str, subStr));
        }
    }
}