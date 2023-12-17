using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环练习2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber;           //定义一个int型变量，用来存储用户输入转变类型后的数字
            string strNumber;        //定义一个字符串变量，用来存储用户初始输入   
            while (true)    //此循环语句的作用是用来判断用户输入的内容是否合法
            {
                Console.WriteLine("请输入一个数字:"); //请用户输入一个数字
                strNumber = Console.ReadLine();
                if (int.TryParse(strNumber, out intNumber)) //int.TryParse()语句判断用户输入的是否为一个整数，如果是，则返回true，反之则返回false；
                {
                    if (Convert.ToInt32(strNumber) > 0)     //代码能够执行到这个地方，说明用户输入的内容是一个整数，这里需要判断用户输入的数字是否在合理的范围之内0
                    {
                        intNumber = Convert.ToInt32(strNumber);  //如果用户输入的数字在合理范围之内，则将用户输入的内容从striing,字符串类型转换为int 整型，并将其赋值给整型变量intNumber;
                        break;        //转换类型并赋值给intNumber后，跳出循环，继续执行循环之外的代码；                   
                    }
                    else
                    {
                        Console.WriteLine("输入的数字不能小于或者等于0！"); //如果用户输入的数字，不在合理范围之内（小于或者等于0），提示用户输入错误，此时重新进行循坏语句，
                    }
                }
                else
                {
                    Console.WriteLine("输入错误，请重新输入！"); //如果用户输入的不是数字，则提示用户输入错误，重新执行循环体内的程序；
                   
                }
            }
            for (int i = 0; i <= intNumber; i++)  //如果以上条件都正确，也就是从break,跳出循环体后，执行这里的for循环
            {
                Console.WriteLine("{0} + {1} = {2}",i,intNumber-i,intNumber);
            }
            Console.ReadKey();
        }
    }
}
