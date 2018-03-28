using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int rnumber = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Choose a number from 1 to 100: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < rnumber)
                    {
                        Console.WriteLine("Wrong, try higher number.");
                        ++count;
                        continue;
                    }
                    else if (input > rnumber)
                    {
                        Console.WriteLine("Wrong, try lower number.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nYou guessed it! The number was {0}.", rnumber);
                        Console.WriteLine("It took you {0} {1}.", count, count == 1 ? "try" : "tries");
                        Console.WriteLine("If you want to exit, type 0.\n");
                        break;
                    }
                }
            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}