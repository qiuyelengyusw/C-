using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用方法判断用户输入是否正确
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            
            while (true) 
            {
                Console.WriteLine("请输入你的年龄：");
                string strAge = Console.ReadLine();
                if (GetNumber(strAge) != 0)          //调用方法来判断用户输入返回的值是否为零，
                {
                    if (GetNumber(strAge) <= 20)
                    {
                        Console.WriteLine("你还是个孩子！");
                        break;
                    }
                    else if (GetNumber(strAge) > 20 && GetNumber(strAge) <= 50)
                    {
                        Console.Write("你已经是个成年人了！");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("你已经老了！");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("输入错误！请重新输入！");    //程序能够执行到这里说明用户输入的内容在方法里返回值为0 ，即用户输入的内容不能转换成int类型，或者用户输入的内容可以转换成int类型但不在合理范围之内
                }
            }
            Console.ReadKey();

        }
        /// <summary>
        /// 判断用户输入的内容是否合法
        /// </summary>
        /// <param name="strNumber">用户输入的内容</param>
        /// <returns>返回用户输入的内容，或者返回0</returns>
        public static int GetNumber(string strNumber)
        {
            while (true) 
            {
                try
                {
                    int intNumber = Convert.ToInt32(strNumber);
                    if (intNumber <= 0 || intNumber>=110)
                    {
                        return 0;
                    }
                    return intNumber;                    
                }
                catch
                {
                    return 0;
                }
            }
        }

    }
}
