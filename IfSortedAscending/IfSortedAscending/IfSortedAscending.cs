namespace IfSortedAscending
{
    class IfSortedAscendingAssignment
    {
        static bool IfSortedAscending(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }

        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.WriteLine("Input 3 integers to see if they are sorted in ascending order.");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the {0} integer", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Are those 3 integers written in ascending order?");
            Console.Write(IfSortedAscending(a));
        }
    }
}