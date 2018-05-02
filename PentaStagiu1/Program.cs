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
            string choiseNumber;
            do
            {
                Console.WriteLine("Introduceti numarul :");
                choiseNumber = Console.ReadLine();
                if (int.Parse(choiseNumber) == randomNumber)
                {
                    Console.WriteLine("Felicitari! Ai ghicit numarul.");

                }
                else if (int.Parse(choiseNumber) < randomNumber)
                {
                    Console.WriteLine($"{int.Parse(choiseNumber)} este mai mic decat cel ales random.");
                }
                else
                {
                    Console.WriteLine($"{int.Parse(choiseNumber)} este mai mare decat cel ales random.");
                }
            } while (int.Parse(choiseNumber) != randomNumber);
        }
    }
}
