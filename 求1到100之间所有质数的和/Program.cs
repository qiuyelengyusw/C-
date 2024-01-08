using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求1到100之间所有质数的和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字:");
            string strNumber = Console.ReadLine();
            int intNumber = GetNumber(strNumber);
            if (IsPrime(intNumber))
            {
                Console.WriteLine("你输入的数字{0}是一个质数！", intNumber);
            }
            else
            {
                Console.WriteLine("你输入的数字{0}不是一个质数!", intNumber);
            }
            //Console.WriteLine(intNumber);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入的是否为数字
        /// </summary>
        /// <param name="strNumber">用户输入的内容</param>
        /// <returns>返回的数字</returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int intNumbers = Convert.ToInt32(strNumber);
                    return intNumbers;
                }
                catch
                {
                    Console.WriteLine("输入错误，请从新输入一个数字:");
                    strNumber = Console.ReadLine();
                }
            }
        }
        public static bool IsPrime(int numbers)
        {
            if (numbers < 2)
            {
                return false;
            }
            for (int i = 0; i < Math.Sqrt(numbers); i++)
            {
                if (numbers % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
