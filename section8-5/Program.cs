using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine();
            var counter = 0;
            var vowel = "aeiouAEIOU";

            foreach (var n in input)
            {
                for (var i = 0; i < vowel.Length; i++)
                {
                    if (n == vowel[i])
                    {
                        counter++;
                    }
                }
                
            }

            Console.WriteLine("Number of vowels: " + counter);

        }
    }
}
