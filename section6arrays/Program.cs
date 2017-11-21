using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //length
            Console.WriteLine("Length: " + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:" + index);

            //clear
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            //sort

            Array.Sort(numbers);

            Console.WriteLine("Effect of sort");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(numbers);
        }
    }
}
