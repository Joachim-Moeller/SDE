namespace IsPalindrome;

internal class IsPalindromeAssignment
{
    private static bool IsPalindrome(string pal)
    {
        for (var i = 0; i < pal.Length / 2; i++)
            if (pal[i] != pal[pal.Length - 1 - i])
                return false;

        return true;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nInput a word to see if it is a palindrome or not.\n");
        Console.Write("Input string: ");
        var pal = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("Your entered word being a palindrome is: ");
        Console.WriteLine(IsPalindrome(pal));
    }
}