using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比较三个数字的大小
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较3个数字的大小不考虑相等的情况
            //第一种方法，这里不考虑用户输入非法格式的问题
            Console.WriteLine("请输入第一个数字：");
            int numberOne =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字：");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine("这三个数中最大的数字是：{0}", numberOne);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine("这三个数中最大的数字是：{0}", numberTwo);
            }
            else
            {
                Console.WriteLine("这三个数中最大的数字是：{0}",numberThree);
            }
            Console.ReadKey();
        }
    }
}
