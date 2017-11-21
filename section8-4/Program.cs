using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words with a space between them");

            var input = Console.ReadLine();
            var words = input.Split(' ');

            Console.WriteLine();
            foreach (var n in words)
            {
                
                Console.Write(Char.ToUpper(n[0]) + n.Substring(1).ToLower());
            }

            Console.WriteLine();

        }
    }
}
