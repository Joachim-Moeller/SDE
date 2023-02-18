namespace AddSeparator;

internal class AddSeparatorAssignment
{
    private static string AddSeparator(string word, string separator)
    {
        //    string[] words = word.Split(separator);

        var separatedWord = string.Empty;

        for (var i = 0; i < word.Length; i++)
            separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();

        return separatedWord;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput string and a separator to separate each character with it.\n");
        Console.Write("Input string to be separated: ");
        var word = Console.ReadLine();
        Console.Write("Input the separator: ");
        var separator = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine(AddSeparator(word, separator));
    }
}