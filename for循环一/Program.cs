using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //一般在一直循环次数的情况下使用for循环
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //用whil循环实现这段代码的功能
            //
            int i = 1;
            while (i <= 100) //当i小于等于100时执行循环体while循环
            {
                Console.WriteLine(i); //输出i的值
                i++;    //i自增1
            }
            Console.ReadKey();
            for (int j = 1; j <= 100; j++)
            {
                Console.WriteLine("这是第{0}次循环,\"j\" 的值现在为{1}", j, j );               
            }
            Console.ReadKey();
        }
    }
}
