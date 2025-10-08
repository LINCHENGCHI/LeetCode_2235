using System;

namespace LeetCode2235
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            int r = Convert.ToInt32(input);

            string input1;
            input1 = Console.ReadLine();
            int k = Convert.ToInt32(input1);
            Console.WriteLine(Sum(r, k));

            int Sum(int num1, int num2)
            {
                //分析函式
                //return(num1 + num2);
                //1.輸入

                //2.處理
                int num;
                num = num1 + num2;
                //3.輸出
                int a;
                a = num;
                return a;
            }
        }
    }
}
