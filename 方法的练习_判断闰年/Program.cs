using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的练习_判断闰年
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要查询的年份：");
            int intYear = Convert.ToInt32(Console.ReadLine());
            bool blA = GetRun(intYear); //调用GetRun（）方法，返回布尔类型的值
            if (blA)
            {
                Console.WriteLine("{0}是闰年", intYear);
            }
            else
            {
                Console.WriteLine("{0}是平年",intYear);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 判断年份是否为闰年
        /// </summary>
        /// <param name="year">给出的年份</param>
        /// <returns>判断是否为闰年</returns>
        public static bool GetRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0); //如果是闰年，则返回true，反之返回flasd
            return b;
        }
    }
}
