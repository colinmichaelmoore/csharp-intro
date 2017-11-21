using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Will convert
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            //Will not convert
            //int i = 1;
            //byte b = i;

            var number = "1234";
            int j = Convert.ToInt32(number);

            try
            {
                string s = "True";
                bool x = Convert.ToBoolean(s);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not convert");
            }
        }
    }
}
