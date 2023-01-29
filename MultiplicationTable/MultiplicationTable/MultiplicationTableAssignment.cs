namespace MultiplicationTable
{
    class MultiplicationTableAssignment
    {
        static void MultiplicationTable()
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    if (a == 1)
                    {
                        if (a * b < 10)
                        {
                            Console.Write($" {a * b} ");
                        }
                        else
                        {
                            Console.Write($"{a * b} ");
                        }
                    }
                    else if (a > 1 && a < 10)
                    {
                        if (a * b < 10)
                        {
                            Console.Write($" {a * b} ");
                        }
                        else
                        {
                            Console.Write($"{a * b} ");
                        }
                    }
                    else
                    {
                        Console.Write($"{a * b} ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            MultiplicationTable();
        }
    }
}