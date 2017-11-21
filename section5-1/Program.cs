using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threenoremainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
