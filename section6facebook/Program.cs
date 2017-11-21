using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names: ");
            var friends = new string[2];
            var counter = 0;
            var input = " ";
            var twoFriends = false;
            do
            {
              input = Console.ReadLine();
                if (twoFriends == false)
                {
                    friends[0] = input;
                    twoFriends = true;
                }
                else
                {
                    friends[1] = input;
                    twoFriends = false;
                }

                Console.WriteLine("Friends: " + friends[0] + " " + friends[1] + " " + counter + " others");
            } while (input != "");
        }
    }
}
