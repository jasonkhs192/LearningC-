using System;
using System.Collections.Generic;

namespace Practice
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            //Problem1: Reverse the int num.
            int num = 12345;
            Problem1 p1 = new Problem1(num);

            //Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            int num1 = 5;
            int num2 = 5;
            Problem2 p2 = new Problem2(num1, num2);
        }
    }
}
