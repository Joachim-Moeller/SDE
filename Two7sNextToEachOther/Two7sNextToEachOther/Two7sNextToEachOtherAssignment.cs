namespace Two7sNextToEachOther
{
    internal class Two7sNextToEachOtherAssignment
    {
        static int Two7sNextToEachOther(int[] arr)
        {
            int Adjacent7s = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    Adjacent7s++;
                }
            }
            return Adjacent7s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Two7sNextToEachOther(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
        }
    }
}