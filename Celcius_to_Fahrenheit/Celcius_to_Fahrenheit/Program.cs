using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Celsius_to_Fahrenheit
{
    class Program
    {
        public class Celsius_to_Fahrenheit
        {
            public static void Main()
            {
                Console.Write("Enter Celsius degrees: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                if (celsius < -271.15)
                    Console.WriteLine("Temperature below absolute zero!");
                
                if (celsius >= -271.15)
                    Console.WriteLine("T = {0}F", celsius * 18 / 10 + 32);
            }
        }
    }
}