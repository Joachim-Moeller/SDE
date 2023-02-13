namespace ToThePowerOf
{
    class ToThePowerOfAssignment
    {
        static int ToThePowerOf(int num, int exp)
        {
            int rvalue = 1;  //rvalue is here short for raisevalue
            int i;
            
            for (i = 1; i <= exp; i++)
                rvalue *= num;
            return rvalue;
        }

        static void Main()
        {
            int num1;
            int exp1;
            
            Console.WriteLine("Calculate one integer raised to the power of another.");
            
            Console.Write("\nInput base number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input exponent number: ");
            exp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n{0} ^ {1} = {2} ", num1, exp1, ToThePowerOf(num1, exp1));
        }
    }
}
