using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将 “What's your name:”打印输出到控制台
            Console.WriteLine("What's your name:");
            //将输入的内容赋值给字符串变量 strname
            string strname = Console.ReadLine();
            //将"How Old Are You?"打印输出到控制台
            Console.WriteLine("How Old Are You? Please Input A Number:");
            //将输入的内容从字符串变量强制转换为int 变量，此处以后应添加判断错误代码，防止用户输入的内容为字符串内容，导致无法转换为int类型导致程序出错
            int Arge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where is your home:");
            string strhome = Console.ReadLine();
            //将输入的内容组合输出到控制台
            Console.WriteLine("Your Name Is :{0},Your Age Is: {1},And Your Home Is :{2}",strname,Arge,strhome);
            //暂停程序
            Console.ReadKey();
        }
    }
}
