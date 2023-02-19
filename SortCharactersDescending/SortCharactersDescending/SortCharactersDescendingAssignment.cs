namespace SortCharactersDescending
{
    internal class SortCharactersDescendingAssignment
    {
        private static char[] SortCharactersDescending(string str)
        {
            var charArray = str.ToCharArray();
            char ch;

            for (var i = 1; i < str.Length; i++)
            for (var j = 0; j < str.Length - 1; j++)
                if (charArray[j] < charArray[j + 1])
                {
                    ch = charArray[j];
                    charArray[j] = charArray[j + 1];
                    charArray[j + 1] = ch;
                }

            return charArray;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput a string to get array of the ASCII characters sorted in descending order.\n");
            Console.Write("Input string: ");
            var str = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Array of the characters sorted in descending order: ");
            Console.WriteLine(SortCharactersDescending(str));
        }
    }
}