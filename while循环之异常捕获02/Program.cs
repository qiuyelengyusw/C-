using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环之异常捕获02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber;
            while (true)
                try
                {
                    Console.WriteLine("请输入一个数字");
                    intNumber = Convert.ToInt32(Console.ReadLine());
                    if (intNumber <= 0 || intNumber >= 50)
                    {
                        Console.WriteLine("输入错误，请输入1到50之间的整数！");
                    }
                    else
                    {
                        Console.WriteLine("你输入的整数是：{0}",intNumber);
                        break;
                    }
                }
                catch 
                {
                    Console.WriteLine("输入错误！");
                }
            Console.WriteLine("感谢使用，按任意键退出程序");
            Console.ReadKey();
        }
    }
}
