namespace SieveOfEratosthenes
{
    internal class SieveOfEratosthenesAssignment
    {
        static bool[] SieveOfEratosthenes(int n)
        {
            bool[] array = new bool[n];

            for (int i = 2; i < n; i++)
            {
                array[i] = true;
            }

            for (int j = 2; j * j <= n; j++)
            {
                if (array[j] == true)
                {
                    for (int k = j * j; k < n; k += j)
                    {
                        array[k] = false;
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Write integer to get its range of prime numbers: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("The range of prime numbers for " + n + " are these: ");
            
            var Primes = SieveOfEratosthenes(n);

            for (int i = 0; i < Primes.Length; i++)
            {
                if (Primes[i] != false)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}