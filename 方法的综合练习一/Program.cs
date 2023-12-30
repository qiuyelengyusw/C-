using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number:");
            string strNumberOne=Console.ReadLine();
            int intNumberOne = GetNumber(strNumberOne);
            Console.WriteLine("Please input the second number:");
            string strNumberTwo =Console.ReadLine();
            int intnumberTwo = GetNumber(strNumberTwo);    //调用方法来判断用户输入是否为数字
            int res = JudgeNumber(intNumberOne,intnumberTwo);
            Console.WriteLine(res); //调用方法来判第一个数字是否小于第二个数字，并计算两个数字的和
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入的是否是一个数字
        /// </summary>
        /// <param name="strNumber">用户输入的内容</param>
        /// <returns>返回用户输入的数字</returns>
        public static int GetNumber(string strNumber)
        {
            while (true) 
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入错误！请从新输入一个数字：");
                    strNumber=Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断用户输入的第一个数字是否小于第二个数字
        /// </summary>
        /// <param name="thisNumberOne">第一个数字</param>
        /// <param name="thisNumberTwo">第二个数字</param>
        /// <returns>返回这两个数字的和</returns>
        public static int JudgeNumber(int thisNumberOne, int thisNumberTwo)
        {
            while(true) 
            {
                if (thisNumberOne < thisNumberTwo)
                {
                    return thisNumberOne + thisNumberTwo;  //如果用户输入满足要求，返回这两个数字的和
                }
                else
                {
                    //如果用户输入的数字不满足要求，则要求用户重新输入
                    Console.WriteLine("输入错误！第一个数字不能大于第一个数字！请重新输入第一个数字：");
                    string strOne = Console.ReadLine();   //重新接受用户输入的内容
                    thisNumberOne= GetNumber(strOne);     //调用方法判断用户输入的内容是否为数字
                    Console.WriteLine("请输入第二个数字：");
                    string strTwo=Console.ReadLine();
                    thisNumberTwo= GetNumber(strTwo);
                }
            }
        }
    }
}
