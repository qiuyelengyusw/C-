using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace 字符串一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串:");
            string strOne = Console.ReadLine();
            //将字符串转换成大写
            //strOne = strOne.ToUpper();
            //将字符串转换成小写
            // strOne=strOne.ToLower();
            Console.WriteLine("请再输入一个字符串:");
            string strTwo = Console.ReadLine();
            if (strOne.Equals(strTwo, StringComparison.OrdinalIgnoreCase)) //括号中的方法作用是指定字符串的比较规则（忽略了两个字符串的大小写）StringComparison.OrdinalIgnoreCase
            {
                Console.WriteLine("你输入的这两个字符串是相同的！这个字符串的长度是{0}", strOne.Length);
            }
            else
            {
                Console.WriteLine("你输入的这两个字符串不相同！第一个字符串的长度是:{0},第二个字符串的长度是:{1}", strOne.Length, strTwo.Length); //字符串.length 计算字符串的长度
            }
            Console.ReadKey();
            //字符串的分割 Split()方法
            string strThree = "abc   ,, 456 ?? #  d e f    = g  + -* /";
            char[] chars = { ' ', ',', '?', '#', '-', '+', '/', '*', '4', '5', '6', '=' };
            string[] strFour = strThree.Split(chars, StringSplitOptions.RemoveEmptyEntries); //Split(chars, StringSplitOptions.RemoveEmptyEntries)方法去掉多余的空
            string s = null;
            for (int i = 0; i < strFour.Length; i++)
            {
                s += strFour[i];
            }
            Console.WriteLine(s);
            Console.ReadKey();

            //练习
            string strA = "2024-1-14";
            string[] strB = strA.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", strB[0], strB[1], strB[2]);
            Console.ReadKey();

            //join()
            string[] strFive = { "张三", "李四", "王五", "赵六", "田七" };
            string strSix = string.Join("|", strFive);
            Console.WriteLine(strSix);
            Console.ReadKey();
        }
    }
}
