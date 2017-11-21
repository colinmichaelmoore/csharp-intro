using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first number: ");
            var one = Console.ReadLine();
            Console.WriteLine("Type second number: ");
            var two = Console.ReadLine();

            //Must compare ints and not strings
            var first = Convert.ToInt32(one);
            var second = Convert.ToInt32(two);

            if (first > second)
            {
                Console.WriteLine(first);
            }
            else if (first < second)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("Equal");
            }



        }
    }
}
