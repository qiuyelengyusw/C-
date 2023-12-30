using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法之ref
{
    internal class Program
    {
        //使用方法来交换两个int 值
        static void Main(string[] args)
        {
            //常规代码：
            int n1 = 10;
            int n2 = 15;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            Jiaohuan(ref n1,ref n2);  //调用方法，将方法中改变的值，传会给原来的变量
            Console.WriteLine(n1);
            Console.WriteLine(n2);  
            Console.ReadKey();
        }
        /// <summary>
        /// 将两个数的值互换
        /// </summary>
        /// <param name="intA">第一个数</param>
        /// <param name="intB">第二个数</param>
        public static void Jiaohuan(ref int intA,ref int intB) //用ref 将传进来的数值进行计算后，将结果在传回给原来的变量
        {
            int temp = intA;
            intA = intB;
            intB = temp;
        }
    }
}
