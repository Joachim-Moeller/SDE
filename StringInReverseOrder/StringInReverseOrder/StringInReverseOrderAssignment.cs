namespace StringInReverseOrder;

internal class StringInReverseOrderAssignment
{
    private static string StringInReverseOrder(string str)
    {
        var reverseString = string.Empty;
        for (var i = str.Length - 1; i >= 0; i--) reverseString += str[i];

        return reverseString;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput a string to have it returned in reverse order.\n");
        Console.Write("Input string: ");
        var str = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.Write("Your reversed string: ");
        Console.WriteLine(StringInReverseOrder(str));
    }
}