using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("Input number for 'a': ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number for 'b': ");
            number2 = int.Parse(Console.ReadLine());
            
            Console.Write("Before: ");
            Console.Write("a = " + number1 + ", ");
            Console.Write("b = " + number2 + "; ");
            //Console.Read();
            
            temp = number1;
            number1 = number2;
            number2 = temp;
            
            Console.Write("After: ");
            Console.Write("a = " + number1 + ", ");
            Console.Write("b = " + number2 + " ");
            Console.Read();
        }
    }
}