using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "Jason";
            string guess = "";
            int count = 3;

            while(count > 0 && guess != secret)
            {
                Console.Write("Enter: ");
                guess = Console.ReadLine();
                if (guess == secret)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        Console.WriteLine("Wrong, try again...\n" + "Try left: " + count);
                    }
                    else
                    {
                        Console.WriteLine("Failed");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
