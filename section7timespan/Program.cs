using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section7timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1, 0, 0);

            Console.WriteLine(timespan);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = start - end;
            Console.WriteLine(duration);
        }
    }
}
