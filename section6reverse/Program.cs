using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name please: ");
            var name = Console.ReadLine();
            var reverse = name.ToCharArray();
            Array.Reverse(reverse);
            var x = new string(reverse);


            
            Console.WriteLine(x);


        }
    }
}
