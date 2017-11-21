using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time in 24 hour format: ");

            var valid = new TimeSpan();
            var input = Console.ReadLine();
            var time = TimeSpan.TryParse(input, out valid);
            
            if (time)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid time");
            }


        }
    }
}
