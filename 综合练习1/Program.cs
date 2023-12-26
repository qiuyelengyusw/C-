using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 综合练习1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //找出1到100之间所有的素数/质数
            //质数是只能被1和本身整除的整数
            for (int i = 2; i < 101; i++) 
            {
                bool b = true; //在这里定义b，是让每次for循环开始的时候，都将true赋值给b
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false; 
                        break;
                    }                   
                }
                if (b) //只有在b=true的时候才能认定这个数是质数
                {
                    Console.WriteLine(i);
                }                
            }
            Console.ReadKey();
        }
    }
}
