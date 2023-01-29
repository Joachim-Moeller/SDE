using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddTwoNumbers
{
    class Program
    {
        public class AddTwoNumbers
        {
            public static void Main()
            {
                float num1, num2, num3;

                Console.Write("Input first number: ");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("Input second number to add: ");
                num2 = float.Parse(Console.ReadLine());

                Console.Write("Input third number to multiply the addition: ");
                num3 = float.Parse(Console.ReadLine());

                float result = (num1 + num2) * num3;
                Console.WriteLine("Output: ({0} + {1}) x {2} = {3}", num1, num2, num3, result);
            }
        }
    }
}