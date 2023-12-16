using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strAnser;
            do  //do while循环的特点是：先执行一遍语句，然后通过while中的循环条件来判断是否继续执行循环
            {
                Console.WriteLine("我回答的正确吗？"); //循环体
                strAnser = Console.ReadLine();  
            } while (strAnser!="yes"); //循环条件是用户输入的内容不是"yes"的情况下，执行循环体
            Console.ReadKey();
        }
    }
}
