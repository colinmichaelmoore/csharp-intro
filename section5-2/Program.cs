using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oktoexit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var counter = 0;

            do
            {
                Console.WriteLine("Enter a number or ok to exit: ");

                input = Console.ReadLine();
                if (input != "ok")
                {
                    var number = Convert.ToInt32(input);
                    counter += number;
                }
            } while (input != "ok");

            Console.WriteLine(counter);
        }
    }
}
