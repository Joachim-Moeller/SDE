namespace NumberOfWords;

internal class NumberOfWordsAssignment
{
    private static int NumberOfWords(string str)
    {
        var numberOfWords = 0;
        for (var i = 1; i < str.Length; i++)
            numberOfWords = char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords;

        return numberOfWords + 1;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput a string and get its number of words.\n");
        Console.Write("Input string: ");
        var str = Console.ReadLine();
        Console.WriteLine("---------------------------------------------------");
        Console.Write("Number of words in your entered string is ");
        Console.WriteLine(NumberOfWords(str));
    }
}