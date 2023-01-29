using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IfGreaterThanThirdOneAssignment
{
    class IfGreaterThanThirdOne
    {
        static bool GreaterThanThirdOne(int[] a)
        {
            return a[0] + a[1] > a[2] || a[0] * a[1] > a[2];
        }
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.WriteLine("Input 3 integers and see if multiplication or sum of the two first numbers is greater than the third one.");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the {0} integer", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.Write(GreaterThanThirdOne(a));
        }
    }
}         
