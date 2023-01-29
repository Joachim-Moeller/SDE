using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Elementary_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You enter two integers and get their addition, subtraction, multiplication, and division results.");
            Console.WriteLine("Enter first integer");
            double input_1 = (int)Convert.ToDouble(Console.ReadLine());

            while (input_1 == 0)
            {
                Console.WriteLine("Number must not be zero");
                Console.WriteLine("Enter first integer");
                input_1 = (int)Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter second integer");
            int input_2 = (int)Convert.ToDouble(Console.ReadLine());

            while (input_2 == 0)
            {
                Console.WriteLine("Number must not be zero");
                Console.WriteLine("Enter second integer");
                input_2 = (int)Convert.ToDouble(Console.ReadLine());
            }

            double addition = input_1 + input_2;
            Console.WriteLine("Addition is {0}", addition);

            double subtraction = input_1 - input_2;
            Console.WriteLine("Subtraction is {0}", subtraction);

            double multiplication = input_1 * input_2;
            Console.WriteLine("Multiplication is {0}", multiplication);

            double division = (double) input_1 / (double) input_2;
            Console.WriteLine("Division is {0}", division);

            Console.ReadLine();
        }
    } 
}