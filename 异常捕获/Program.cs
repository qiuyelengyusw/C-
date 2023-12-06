using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //先声明一个变量，因为变量是有作用域的，如果在try里面声明 int Arge，在try的括号外，超出了Arge的作用范围
            //所以要在main函数内声明这个int 变量，并将0作为这个变量的初始值
            int Arge = 0;
            //定义一个布尔型变量，用于在异常捕获的程序中判断是否要执行指定的代码
            bool b = true;
            //将 “What's your name:”打印输出到控制台
            Console.WriteLine("What's your name:");
            //将输入的内容赋值给字符串变量 strname
            string strname = Console.ReadLine();
            //将"How Old Are You?"打印输出到控制台
            Console.WriteLine("How Old Are You? Please Input A Number:");
            //将输入的内容从字符串变量强制转换为int 变量，此处以后应添加判断错误代码，止用户输入的内容为字符串内容，导致无法转换为int类型导致程序出错
            try
            {
                 Arge = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You Are Input Is Not An int! Plese Input An Int Number Again:");
                //如果代码执行到这里说明代码已经发生错误，在将false 赋值给b
                b = false;
            }
            //通过对布尔型b的值来判断代码是否出现异常错误，并用if语句来判断并决定是否要执行下面的代码
            if(b)
            {
                Console.WriteLine("Where is your home:");
                string strhome = Console.ReadLine();
                //将输入的内容组合输出到控制台
                Console.WriteLine("Your Name Is :{0},Your Age Is: {1},And Your Home Is :{2}", strname, Arge, strhome);
            }            
            //暂停程序
            Console.ReadKey();
        }
    }
}
 