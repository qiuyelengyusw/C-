using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法之params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test("张三",100,99,100);  //用方法中的params 将数字转化成了一个数组
            Console.ReadKey();
        }
        public static void Test(string strName,params int[] ints)  
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++) 
            {
                sum += ints[i];
            }
            Console.WriteLine("{0}这次的考试总成绩是：{1}",strName,sum);
        }
    }
}
