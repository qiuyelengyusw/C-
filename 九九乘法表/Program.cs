using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++) //外层循环控制行数
            {
                for (int j = 1; j <= i; j++)  //内层循环控制列数
                {
                    Console.Write("{0}x{1}={2}\t", j, i, i * j); //输出乘法表
                }
                Console.WriteLine(); // 换行
            }
            Console.ReadKey();       //等待用户输入     
            Console.WriteLine("下面是用while循环实现的九九乘法表");
            int k = 1;  //外层循环控制行数
            while (k <= 9) //外层循环控制行数
            {
                int h = 1; //内层循环控制列数
                while (h <= k) //   内层循环控制列数
                {
                    Console.Write("{0}x{1}={2}\t", h, k, h * k);
                    h += 1; //内层循环变量自增
                }
                Console.WriteLine();
                k +=1; //外层循环变量自增
            }
            Console.ReadKey();
        }
    }
}
