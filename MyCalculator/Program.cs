namespace MyCalculator
{
    public class Program
    {
        public static double Result { get; private set; }

        public static void Main(string[] args)
        {
            string ExitOption;

            while (true)
            {
                Console.WriteLine("Enter two numbers and their operator (+, -, *, /, or ^)");
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Operator: ");
                string op = Console.ReadLine() ?? "";

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.Write(num1);
                    Console.Write(" + ");
                    Console.Write(num2);
                    Console.Write(" = ");
                    double result = (num1 + num2);
                    Console.WriteLine(result);
                }
                else if (op == "-")
                {
                    Console.Write(num1);
                    Console.Write(" - ");
                    Console.Write(num2);
                    Console.Write(" = ");
                    double result = (num1 - num2);
                    Console.WriteLine(result);

                }
                else if (op == "*")
                {
                    Console.Write(num1);
                    Console.Write(" * ");
                    Console.Write(num2);
                    Console.Write(" = ");
                    double result = (num1 * num2);
                    Console.WriteLine(result);

                }
                else if (op == "/")
                {
                    Console.Write(num1);
                    Console.Write(" / ");
                    Console.Write(num2);
                    Console.Write(" = ");
                    double result = (num1 / num2);
                    Console.WriteLine(result);

                }
                else if (op == "^")
                {
                    Console.Write(num1);
                    Console.Write(" ^ ");
                    Console.Write(num2);
                    Console.Write(" = ");
                    double result = Math.Pow(num1, num2);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid Operator");
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                ExitOption = Console.ReadLine();
                if (ExitOption.ToLower() == "n")
                {
                    break;
                }
                else
                    continue;
            }
        }
    }
}