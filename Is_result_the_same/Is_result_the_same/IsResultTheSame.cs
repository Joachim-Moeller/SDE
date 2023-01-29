using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Is_result_the_same
{
    class IsResultTheSame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number 'a'");
            double a = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number 'b'");
            double b = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third number 'c'");
            double c = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number 'd'");
            double d = (double)Convert.ToDouble(Console.ReadLine());

            double additionAplusB = a + b; 
            Console.WriteLine("Addition of 'a' and 'b' is {0}", additionAplusB);

            double additionCplusD = c + d;
            Console.WriteLine("Addition of 'c' and 'd' is {0}", additionCplusD);

            double subtractionAminusB = a - b;
            Console.WriteLine("Subtraction of 'b' from 'a' is {0}", subtractionAminusB);

            double subtractionCminusD = c - d;
            Console.WriteLine("Subtraction of 'd' from 'c' is {0}", subtractionCminusD);

            double multiplicationAtimesB = a * b;
            Console.WriteLine("Multiplication of 'a' and 'b' is {0}", multiplicationAtimesB);

            double multiplicationCtimesD = c * d;
            Console.WriteLine("Multiplication of 'c' and 'd' is {0}", multiplicationCtimesD);

            double divisionAdivB = (double)a / (double)b;
            Console.WriteLine("Division of 'a' by 'b' is {0}", divisionAdivB);

            double divisionCdivD = (double)c / (double)d;
            Console.WriteLine("Division of 'c' by 'd' is {0}", divisionCdivD);

            Console.WriteLine("Is a+a and a*a the same? " + IsRes(a + a, a * a));
            Console.WriteLine("Is a+a and a/a the same? " + IsRes(a + a, a / a));
            Console.WriteLine("Is b+b and b*a the same? " + IsRes(b + b, b * b));
            Console.WriteLine("Is b+b and b/b the same? " + IsRes(b + b, b / b));
            Console.WriteLine("Is a+b and a*b the same? " + IsRes(a + b, a * b));
            Console.WriteLine("Is a+b and a/b the same? " + IsRes(a + b, a / b));
            Console.WriteLine("Is a/b and a-b the same? " + IsRes(a / b, a - b));
        }
            private static bool IsRes(double a, double b)
            {
                if (a == b) return true;
                else return false;
            }
    }
}


