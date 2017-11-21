using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxofnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers seperated by commas: ");
            var input = Console.ReadLine();
            input = input.Replace(",", "");
            
            var numbers = new int[input.Length];
            var max = 0;
            for (var x = 0; x < input.Length; x++)
            {
                
                numbers[x] = (int)Char.GetNumericValue(input[x]);
                

                if (numbers[x] > max)
                {
                    max = numbers[x];
                }
            }
            

            Console.WriteLine(max);
        }
    }
}
