using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较两个数字的大小
            //Console.WriteLine("请输入第一个数字：");
            //int intNumberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //int intNumberTwo=Convert.ToInt32(Console.ReadLine());
            //#region 方法一
            ////if (intNumberOne > intNumberTwo)
            ////{
            ////    Console.WriteLine("这两个数中最大的数字是：{0}", intNumberOne);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("这两个书中最大的数字是：{0}",intNumberTwo);
            ////}
            //#endregion
            //#region 方法二三元表达式
            //int intNumberThree = intNumberOne > intNumberTwo ? intNumberOne : intNumberTwo;     //如果intNumberOne > intNumberTwo ,那么intNumberOne就是最大值，反之就是intNumberTwo为最大值
            //Console.WriteLine("这两个数中最大的数是:{0}",intNumberThree);
            //#endregion
            //Console.ReadKey();
            Console.WriteLine("你的姓名：");
            string  strName = Console.ReadLine();

            string strName1 = strName == "生威" ? "天才" : "SB";
            Console.WriteLine(strName1);
            Console.ReadKey();
        }

    }
}
