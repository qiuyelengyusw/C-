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
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
