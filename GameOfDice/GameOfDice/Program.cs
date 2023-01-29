namespace GameOfDice
{
    class RandomDice
    {
        static void Main(string[] args)
        {
            Random r = new();
            Console.Write("Input number of dice to see needed attempts before all dice show 6: ");
            int nDice = Convert.ToInt32(Console.ReadLine());
            int Attempts = 0;
            int Sixes = 0;

            while (true)
            {
                Attempts++;
                int Roll = r.Next(1, 7);

                if (Roll == 6)
                {
                    Sixes++;

                    if (Sixes == nDice)

                        break;
                }
                else
                    Sixes = 0;
            }
            Console.Write("Attempts needed before all dice showed 6 was " + Attempts / nDice + " attempts.");
            Console.Read();
        }
    }
}