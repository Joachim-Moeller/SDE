namespace FullSequenceOfLettersM
{
    internal class FullSequenceOfLettersAssignment
    {
        static string FullSequenceOfLetters(string word)
        {
            string FullSequence = string.Empty;
            for (int i = word[0], j = 0; i <= word[1]; i++, j++)
            {
                FullSequence += (char)(word[0] + j);
            }
            return FullSequence;
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two letters, 1st letter being before 2nd letter in the alphabet");
            Console.WriteLine("and get full sequence of letters between them, themselves included: ");
            string word = Console.ReadLine();
            Console.Write("The full sequence is ");
            Console.WriteLine(FullSequenceOfLetters(word));    
        }
    }
}