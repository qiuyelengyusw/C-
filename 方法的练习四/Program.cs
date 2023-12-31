using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 方法的练习四
{
    internal class Program
    {
        //写一个方法，判断用户输入的数字是不是质数
        //写一个方法，要求用户只能输入整数，否则一直要求用户重新输入
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            string strNumber = Console.ReadLine();
            int intNumber = GetJues(strNumber);
            if (GetBol(intNumber))
            {
                Console.WriteLine("您输入的整数是质数");
            }
            else
            {
                Console.WriteLine("您输入的整数不是质数");
            }
            Console.ReadKey();

        }
        /// <summary>
        /// 判断用户输入的是否为一个整数
        /// </summary>
        /// <param name="nums">用户输入的内容</param>
        /// <returns>返回用户输入的整数</returns>
        public static int GetJues(string nums)
        {
            while (true)
            {
                try
                {
                    int intnums = Convert.ToInt32(nums);
                    return intnums;

                }
                catch
                {
                    Console.WriteLine("输入的不是一个整数！请重新输入：");
                    nums = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断用户输入的整数是否是一个质数
        /// </summary>
        /// <param name="n1">用户输入的整数</param>
        /// <returns>返回判断的结果</returns>
        public static bool GetBol(int n1)
        {
            if (n1 < 2)  //如果用户输入的整数小于2，则不是质数，因为最小的质数是2
            {
                return false;
            }
            else    //如果用户输入的整数大于2
            {
                for (int i = 2; i < n1; i++)  //判断是否为质数(让这个数字从2开始除，除到自身的前以为，比如：7/2 7/3 7/4 7/5 7/6)，如果能整除，说明这个数不是质数
                {
                    if (n1 % i == 0) //如果满足这个条件，表示不是质数，返回false
                    {
                        return false;
                    }
                }
                return true; //如果用户输入的数字大于等于2，并且不满足上面的循环内的条件，则说明这个数是质数，返回true
            }

        }
    }
}
