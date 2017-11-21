using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height of image: ");
            var one = Console.ReadLine();
            Console.WriteLine("Enter width of image: ");
            var two = Console.ReadLine();

            //Must compare ints and not strings
            var first = Convert.ToInt32(one);
            var second = Convert.ToInt32(two);

            if (first > second)
            {
                Console.WriteLine("Portrait");
            }
            else if (first < second)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Square picture");
            }
        }
    }
}
