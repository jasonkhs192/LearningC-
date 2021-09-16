using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Problem1
    {
        public int num;
        public int rev_num;
        public int digit;
        public int check;

        public Problem1(int aNum)
        {
            num = aNum;
            rev_num = 0;
            while (num > 0)
            {
                digit = num % 10;
                rev_num = rev_num * 10 + digit;
                num = num / 10;
            }
            check = rev_num * 10;
            if (check / 10 != rev_num)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(rev_num);
            }
            Console.Read();
        }
    }
}
