using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算两个整数之间的最大值
            Console.WriteLine(Program.GetMax(35,55)); //调用GetMax()方法 如果方法与Main再一个类下，可以省略Program直接调用GetMax()
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数的最大值，并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1, int n2)
        {
            //这里运用了三元表达式
            return n1 > n2 ? n1 : n2; //return有两个作用，一、返回方法中的返回值，二、立即结束方法
        }
    }
}
