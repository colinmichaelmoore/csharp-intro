using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace section9_files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\somefile.jpg";

            File.Copy(@"c:\temp", @"c:\temp.jpg");
            File.Delete(path);

            
        }
    }
}
