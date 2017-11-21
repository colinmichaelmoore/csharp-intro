using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4,};

            foreach (var nums in numbers)
            {
                Console.WriteLine(nums);
            }

            var x = 0;

            while (x < 10)
            {
                Console.WriteLine(x);
                x++;

            }
        }
    }
}
