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
            //Substring 截取字符串
            string strB = "把所有想的念的错的痛的都放在心房，行李箱里装不下我想要去的远方";
            if(strB.StartsWith("把所有")&&strB.EndsWith("远方"))
            {
                Console.WriteLine("是的");
            }
            else
            {
                Console.WriteLine("不是的");
            }
            //indexof()
            int index = strB.IndexOf('心');
            Console.WriteLine("心"+"第一次出现的地方是{0}",index);
            strB = strB.Substring(10,4);
            Console.WriteLine(strB);    
            Console.ReadKey();

           

        }
    }
}
