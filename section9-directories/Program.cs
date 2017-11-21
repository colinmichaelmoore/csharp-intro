using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace section9_directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp");
            var files = Directory.GetFiles(@"c:\temp", "*", SearchOption);


            var directories = Directory.GetDirectories(@"c:\", "*");

            var directoryinfo = new DirectoryInfo();


        }
    }
}
