namespace CompressString;

internal class CompressStringAssignment
{
    private static string CompressString(string str)
    {
        var count = 0;
        var last = str[0];
        var newStr = string.Empty;

        foreach (var c in str)
            if (c == last)
            {
                count++;
            }
            else
            {
                newStr += last.ToString() + count;
                last = c;
                count = 1;
            }

        newStr += last.ToString() + count;

        return newStr;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput a string to get it in compressed format.\n");
        Console.Write("Input string: ");
        var str = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.Write("The compressed string: ");
        Console.WriteLine(CompressString(str));
    }
}