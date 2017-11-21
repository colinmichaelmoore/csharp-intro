using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers with dashes seperating them: ");

            var input = Console.ReadLine();
            var inputArray = input.Split('-');
            var sorted = new string[inputArray.Length];
            var consecutive = true;
            var consecutive2 = true;
            
            for (var i = 0; i < inputArray.Length; i++)
            {
                sorted[i] = inputArray[i];
            }

            Array.Sort(sorted);

            for (var j = 0; j < sorted.Length; j++)
            {
                if (inputArray[j] != sorted[j])
                {
                    consecutive = false;
                    
                    break;
                }

            }

            Array.Reverse(sorted);

            for (var x = 0; x < sorted.Length; x++)
            {
                if (inputArray[x] != sorted[x])
                {
                    consecutive2 = false;
                    
                    break;
                }

            }

            if (consecutive == true || consecutive2 == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }


            

        }
    }
}
