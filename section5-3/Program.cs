using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and get it's factorial: ");

            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            var factorial = 1;

            for (var i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(number + "! = " + factorial);
        }
    }
}
