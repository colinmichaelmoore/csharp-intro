using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6quit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers or type quit to exit ");
            var numbers = new List<int>();
            var input = "";
            do
            {
                input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                var myInt = Convert.ToInt32(input);
                numbers.Add(myInt);
            } while (input != "quit");
            Console.WriteLine();
            foreach (var n in numbers)
            {
                Console.Write(" " + n + " ");
            }
        }
    }
}
