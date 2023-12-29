using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习之out判断用户登录
{
    internal class Program
    {
        //返给用户登录信息
        //提示用户登录成功，或者登录失败，并提示用户，错误信息
        static void Main(string[] args)
        {
            string messg;
            Console.WriteLine("请输入您的用户名：");
            string strName = Console.ReadLine();
            Console.WriteLine("请输入您的密码："); 
            string strPwd= Console.ReadLine();
            IsLong(strName,strPwd,out messg);
            Console.WriteLine(messg);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入是否正确
        /// </summary>
        /// <param name="name">输入的用户名</param>
        /// <param name="pwd">输入的密码</param>
        /// <param name="msg">返给用户的登录信息</param>
        /// <returns>返回登录结果</returns>
        public static bool IsLong(string name, string pwd, out string msg)  //定义一个bool方法，返回一个string 类型的值，用于返给用户登录信息
        {
            if (name == "admin" && pwd == "aaa123456")  //如果用户输入的用户名以及密码都正确
            {
                msg = "登录成功！";  //提示登录成功
                return true;       //返回true
            }
            else if (name == "admin")  //说明用户名输入正确，但是密码输入不正确
            {
                msg = "密码错误！";
                return false;
            }
            else if (pwd == "aaa123456")  //密码输入正确，但是用户名输入不正确
            {
                msg = "用户名错误！";
                return false;
            }
            else    //用户名以及密码输入都不正确
            {
                msg = "用户名和密码都错误！";
                return false;
            }
        }
          
    }
}
