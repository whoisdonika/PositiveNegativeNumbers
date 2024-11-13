using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Numbers numbers = new Numbers();

            Console.Write("Enter a number : ");
            double number = double.Parse(Console.ReadLine());

            bool result = numbers.IsPositive(number);
            Console.WriteLine( result);
        }

       
    }
}
