using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环的练习1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //求1到100至今所有整数的和
            int intSum = 0;
            int intSumeven = 0; 
            int intSumodd = 0;  
            for (int i = 1; i < 100; i++)
            {
                intSum += i;
                if (i % 2 == 0)
                {
                    intSumeven += i;
                }
                else
                {
                    intSumodd += i; 
                }
            }
            Console.WriteLine("1到100之间\n所有整数的和是：{0}\n所有偶数的和是：{1}\n所有奇数的和是：{2}",intSum,intSumeven,intSumodd);  
            
            Console.ReadKey();

        }
    }
}
