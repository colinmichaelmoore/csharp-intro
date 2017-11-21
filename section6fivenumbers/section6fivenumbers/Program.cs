using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6fivenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five unique numbers: ");
            var numbers = new int[5];
            var counter = 0;

            do
            {
                var input = Console.ReadLine();
                var makeint = Convert.ToInt32(input);
                if (numbers.Contains(makeint))
                {
                    Console.WriteLine("Number not unique! Try again: ");
                }
                else
                {
                    numbers[counter] =  makeint;
                    counter++;
                }

            } while (counter < 5);

            Array.Sort(numbers);

            Console.WriteLine();

            foreach (var n in numbers)
            {

                Console.Write(n);
            }

        }
    }
}
