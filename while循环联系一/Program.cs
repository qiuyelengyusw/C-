using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环联系一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入用户名和密码，用户名是：admin,密码是：aaa123456，如果用户名或者密码错误，则提示用户哪里错误，需要重新输入
            string strName = "";
            string strPassword = "";
            Console.WriteLine("请输入用户名：");
            strName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            strPassword = Console.ReadLine();
            while (strName != "admin" || strPassword != "aaa123456")
            {
                Console.WriteLine("用户名或密码错误，请重新输入！");
                Console.WriteLine("请重新输入用户名：");
                strName = Console.ReadLine();
                Console.WriteLine("请重新输入密码：");
                strPassword = Console.ReadLine();   
            }
            Console.WriteLine("输入正确，欢迎登录！");
        }
    }
}
