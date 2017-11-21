using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var random = new Random().Next(1, 10);
            var chances = 5;
          

            do
            {
                Console.WriteLine("Guess the random number between 1 and 10: ");
                var input = Console.ReadLine();
                chances--;
                var number = Convert.ToInt32(input);
                
                if (number == random)
                {
                    Console.WriteLine("You win");
                }
                else if (chances <= 1)
                {
                    Console.WriteLine("You lose");

                }
            } while (chances > 1);
        

            //Console.WriteLine(random);


        }
    }
}
