using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedlimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit: ");
            var one = Console.ReadLine();
            Console.WriteLine("Enter speed of vehicle: ");
            var two = Console.ReadLine();

            //Must compare ints and not strings
            var first = Convert.ToInt32(one);
            var second = Convert.ToInt32(two);
            var difference = second - first;    

            if (second < first)
            {
                Console.WriteLine("Ok");
            }
            else if (difference / 5 >= 12)
            {
                Console.WriteLine("License suspended");
            }
            else
            {
                Console.WriteLine(difference / 5);
            }
        }
    }
}
