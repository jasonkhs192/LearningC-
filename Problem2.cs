using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Problem2
    //Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
    {
        public int num1;
        public int num2;
        public Problem2(int aNum1, int aNum2)
        {
            num1 = aNum1;
            num2 = aNum2;

            if (num1 == num2)
            {
                int sum = num1 + num2;
                Console.WriteLine(sum * sum * sum);
            }
            else
            {
                Console.WriteLine(num1+num2);
            }
            Console.ReadLine();
        }
    }
}
