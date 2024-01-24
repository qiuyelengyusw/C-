using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合的练习二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符串数组
            Console.WriteLine("请输入一个字符串：");
            string input=Console.ReadLine();
            //char[] chars = input.ToCharArray();
            //string[] str = new string[chars.Length];
            //int i = 0;
            //foreach (char c in chars ) 
            //{
            //    str[i] = c.ToString();
            //    i++;               
            //}
            //foreach (var s in str )
            //{
            //    Console.Write(s+" ");
            //}
            string[] stra=input.ToString().Split();
            foreach(string str in stra) 
            {
                Console.Write(str+"|");
            }
            Console.ReadKey();
        }
    }
}
