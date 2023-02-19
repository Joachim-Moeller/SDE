namespace RevertWordsOrder
{
    internal class RevertWordsOrderAssignment
    {
        private static string RevertWordsOrder(string str)
        {
            var strArray = str.Split(' ');
            var len = strArray.Length;

            for (var i = 0; i < len / 2; i++)
            {
                var temp = strArray[i];

                if (i == 0)
                {
                    strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
                    strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);
                }
                else
                {
                    strArray[i] = strArray[len - 1 - i];
                    strArray[len - 1 - i] = temp;
                }
            }

            return string.Join(" ", strArray);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput a string and have the order of its words returned.\n");
            Console.Write("Input string (must end with a period): ");
            var str = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Your reversed string: ");
            Console.WriteLine(RevertWordsOrder(str));
        }
    }
}