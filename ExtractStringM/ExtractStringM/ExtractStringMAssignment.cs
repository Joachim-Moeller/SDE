namespace ExtractStringM
{
    internal class ExtractStringMAssignment
    {
        static string ExtractString(string word)
        {
            string Extraction = string.Empty;
            bool FirstTime = false;
            bool SecondTime = false;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] == '#' && word[i + 1] == '#')
                {
                    FirstTime = true;
                    for (int j = i + 2; j <= word.Length - 1; j++)
                    {
                        if (word[j] == '#' && word[j + 1] == '#')
                        {
                            SecondTime = true;
                            return Extraction;
                        }
                        Extraction += word[j];
                    }
                }
            }
            return string.Empty;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string; if 2 instances of #, returns substring between the 2 #s, otherwise returns nothing.");
            Console.Write("Enter string: ");
            string word = Console.ReadLine();
            Console.Write("Extracted substring: ");
            Console.WriteLine(ExtractString(word));
        }
    }
}