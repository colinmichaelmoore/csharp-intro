using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace section9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFile = File.ReadAllText(@"c:\Users\colin\Documents\text.txt");
            Console.WriteLine(textFile);
            Console.WriteLine();
            var number = textFile.Split(' ');

            Console.WriteLine("Number of words the file contains: " + number.Length);
        }
    }
}
