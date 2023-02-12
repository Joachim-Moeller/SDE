namespace TheBiggestNumber
{
    class TheBiggestNumberAssignment
    {

        static int TheBiggestNumber(int[] arr)
        {
            int Biggest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Biggest)
                {
                    Biggest = arr[i];
                }
            }
            return Biggest;
            }

        static void Main(string[] args)
        {
            Console.WriteLine(TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 200 }));
            Console.WriteLine(TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }));
            Console.ReadLine();
        }
    }
}