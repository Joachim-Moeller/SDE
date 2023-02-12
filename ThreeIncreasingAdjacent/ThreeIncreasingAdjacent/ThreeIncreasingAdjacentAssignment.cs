namespace ThreeIncreasingAdjacent
{
    internal class ThreeIncreasingAdjacentAssignment
    {
        static bool ThreeIncreasingAdjacent(int[] arr)
        {
            bool result = false;
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if (arr[i + 1] - 1 == arr[i] && arr[i - 1] + 1 == arr[i])
                {
                    result = true;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
        }
    }
}