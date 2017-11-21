using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace section9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFile = File.ReadAllText(@"c:\Users\colin\Documents\text.txt");
            Console.WriteLine(textFile);
            Console.WriteLine();
            var number = textFile.Split(' ');
            var longest = "";

            for (var i = 0; i < number.Length - 1; i++)
            {
                if (number[i].Length > number[i + 1].Length)
                {
                    longest = number[i];
                }
                else
                {
                    longest = number[i + 1];
                }
            }

            Console.WriteLine("Longest word the file contains: " + longest);
        }
    }
}
