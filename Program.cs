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
            string x = "Jason Kim";
            Console.WriteLine(x.Substring(3));
            Console.WriteLine(Math.Abs(-123));
            Console.WriteLine(Math.Pow(2, 2));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(321, 1));
            Console.WriteLine(Math.Round(4.7) + " | " + Math.Round(4.2));
            string num2 = "236432";
            int num = Convert.ToInt32(num2);
            Console.WriteLine(num);
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(name + age + height);
            Console.ReadLine();

            string champion, role = "";
            


            
        }
    }
}
