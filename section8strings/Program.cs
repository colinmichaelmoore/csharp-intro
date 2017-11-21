using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section8strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Colin Moore ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.ToUpper());


            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First: " + firstName);
            Console.WriteLine("Last: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First: " + names[0]);
            Console.WriteLine("Last: " + names[1]);

            Console.WriteLine(fullName.Replace("Colin", "Bob"));

            if(String.IsNullOrWhiteSpace(null))
                Console.WriteLine("Invalid");



        }
    }
}
