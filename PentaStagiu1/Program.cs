using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            GhicesteNumarul();

        }
        static void GhicesteNumarul()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            int choiseNumber=-1;
            do
            {
                Console.WriteLine("Introduceti numarul :");
                choiseNumber = int.Parse(Console.ReadLine());
                if (choiseNumber == randomNumber)
                {
                    Console.WriteLine("Felicitari! Ai ghicit numarul.");

                }
                else if (choiseNumber < randomNumber)
                {
                    Console.WriteLine($"{choiseNumber} este mai mic decat cel ales random.");
                }
                else
                {
                    Console.WriteLine($"{choiseNumber} este mai mare decat cel ales random.");
                }
            } while (choiseNumber != randomNumber);
        }
    }
}
