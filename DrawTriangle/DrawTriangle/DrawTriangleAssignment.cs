namespace DrawTriangle
{
    internal class DrawTriangleAssignment
    {
        static void Main(string[] args)
        {
            int n, x, y, z;

            n = 10; //antal rækker

            for (x = 1; x <= n; x++) //main outer loop printer 10 rækker
            {
                for (y = 1; y <= n - x; y++) //printer mellemrummene
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++) //printer x, dvs *
                {
                    Console.Write("* "); //mellemrum indsat efter * så det ligner en ordentlig trekant
                }
                Console.WriteLine();
            }
        }
    }
}
