using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers seperated by hyphens... ");
            var input = Console.ReadLine();
            var inputArray = input.Split('-');
            var inputArray2 = input.Split('-');
            var duplicate = false;
            Array.Sort(inputArray);
            Array.Sort(inputArray2);

            

            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                if (input.Length < 1) { break; }
                    
                    if (inputArray[i] == inputArray[i + 1])
                    {
                        duplicate = true;
                        break;
                    }
                
                    
                
            }

            if (duplicate == true)
            {
                Console.WriteLine("Duplicate");
            }
       


        }
    }
}
