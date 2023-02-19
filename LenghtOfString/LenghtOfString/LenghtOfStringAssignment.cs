namespace LenghtOfString;

internal class LenghtOfStringAssignment
{
    private static int LengthOfAString(string str)
    {
        var length = 0;
        foreach (var c in str) length++;

        return length;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput a string to see its lenght\n");
        Console.Write("Input string: ");
        var str = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("The lenght of your string is ");
        Console.Write(LengthOfAString(str));
    }
}