using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Modulo_operations
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Enter third integer");
            int input_3 = (int)Convert.ToDouble(Console.ReadLine());

            while (input_3 == 0)
            {
                Console.WriteLine("Number must not be zero");
                Console.WriteLine("Enter third integer");
                input_3 = (int)Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("ModuloOperations = ");
            Console.Write((input_1 % input_2) % input_3);
            Console.ReadLine();
        }
    }
}