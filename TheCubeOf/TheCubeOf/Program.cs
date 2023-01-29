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
            Console.WriteLine("Write a number");
            double number = (double)Convert.ToDouble(Console.ReadLine());

            while (number == 0)
            {
                Console.WriteLine("Number must not be zero");
                Console.WriteLine("Write a number");
                number = (double)Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("The cube of ");
            Console.Write((double)number);
            Console.Write(" is ");
            Console.Write(number * number * number);

            Console.ReadLine();
        }
    }
}