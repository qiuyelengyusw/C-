using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //只允许输入yes或者no ，否则提示重新输入
            Console.WriteLine("请输入yes或者no");
            string stra = Console.ReadLine();   
            IsYesOrNo(stra);
            Console.WriteLine(stra);
           // Console.ReadKey();
        }
        /// <summary>
        /// 限定用户只能输入yes或者no
        /// </summary>
        /// <param name="strInput">需要判断的用户的输入内容</param>
        /// <returns>返回限定的值</returns>
        public static string IsYesOrNo(string strInput)
        {
            while (true) 
            {
                if (strInput == "yes" || strInput == "no")
                {
                    return strInput;
                }
                else
                {
                    Console.WriteLine("输入错误！请重新输入");
                    strInput = Console.ReadLine();
                }
            }
        }
    }
}
