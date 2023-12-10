using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断闰年
{
    internal class Program
    {
        //判断用户输入的年份是否为闰年
        static void Main(string[] args)
        {
            bool b =true; //定义一个布尔型变量，用来作为while的循环条件，当这个变量的值为false是，循环停止
            int intYear;   //定义一个int类型变量，用来存储用户输入的年份       
           
            while (b) //此循环的作用是判断用户输入的信息格式是否正确及是否在合理的范围之内；如果不符合要求，则提示用户再次输入正确的内容；
            {
                Console.WriteLine("请输入您要查询的年份："); //提示用户输入想要查询的年份；
                string strYear = Console.ReadLine();      //将用户输入的内容赋值给字符串变量
                if (int.TryParse(strYear, out intYear))   //首先判断用户输入的是否为整数；
                {
                    intYear = Convert.ToInt32(strYear);   //如果用户输入的是整数。则用convert.toint32语句将字符串变量强制转换成整形变量；
                    if (intYear > 0)  //这里判断用户输入的年份是否小于或者等于0
                    {
                        if (intYear % 400 == 0 || intYear % 4 == 0 && intYear % 100 != 0) //如果用户输入的内容在合理范围之内，则判断用户输入的年份是否满足“可以被400整除，过着可以被4整除但同时不能被100整除”
                        {
                            Console.WriteLine("您查询的{0}年，是闰年", intYear);             //如果满足上述条件，则说明用户输入的年份是闰年，并打印输出到控制台              
                            b= false;   //最后将循环条件变量赋值为false；作用是结束循环，执行循环体下面的语句；
                        }
                        else
                        { 
                            Console.WriteLine("您查询的{0}年，是平年", intYear); 
                            b = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入错误，年份不能小于或者等于零！请重新输入！"); //如果用户输入的年份不在合理范围之内，提示用户错误原因，并要求客户重新输入
                    }
                }
                else
                {
                    Console.WriteLine("格式错误！请正确输入您要查询的年份！");  //如果用户输入的不是个整数，则提示用户错误原因，并要求用户重新输入；
                }

            }
            Console.WriteLine("感谢使用，请按任意键退出程序！");//程序推出提示
            Console.ReadKey();
        }
    }
}
