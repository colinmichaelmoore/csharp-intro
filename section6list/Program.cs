using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by commas and get the three smallest displayed..");
            Console.WriteLine("List must be atleast 5 numbers long.");

            var numbers = new List<int>();
            var input = Console.ReadLine();
            input.Split(',');
            

            for(var i = 0; i < input.Length; i++)
            {
                var holder = input[i];
                
                numbers.Add(holder);
                
            }

            foreach (var n in numbers)
            {
               
                Console.Write(n);
            }




        }
    }
}
