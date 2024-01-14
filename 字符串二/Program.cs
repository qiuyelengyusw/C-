using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "国家关键人物老王";
            if(strA.Contains("老王")) //判断字符串中是否存在指定的字符
            {
               strA= strA.Replace("老王","**");  //将字符串中的字符替换成其他字符
            }
            Console.WriteLine(strA);
            Console.ReadKey();
        }
    }
}
