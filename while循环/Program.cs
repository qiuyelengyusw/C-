using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            int sumEven = 0;   
            int sumOdd = 0; 
            while (i <= 100) 
            { 
                Console.WriteLine("这是循环的第{0}次；",i);
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
                if (i % 2 != 0) 
                {
                    sumOdd += i;
                }
                sum += i;
                i++;
            }
            Console.WriteLine("1到100之间所有整数的和为{0}",sum);
            Console.WriteLine("1到100之间所有偶数的和为{0}",sumEven);
            Console.WriteLine("1到100之间所有奇数的和为{0}",sumOdd);
            Console.ReadKey();  
        }
    }
}
