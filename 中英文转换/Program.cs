using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中英文转换
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] english = { "red", "blue", "yellow", "black", "white" ,"green"};
            string[] chinese = { "红色", "蓝色", "黄色", "黑色", "白色","绿色" };
            Hashtable ht = new Hashtable();
            for (int i = 0; i < chinese.Length; i++)
            {
                ht.Add(chinese[i], english[i]);
            }
            Console.WriteLine("请输入需要翻译成英文的颜色：");
            string ch = Console.ReadLine();
            foreach (string chs in ht.Keys)
            {
                //if (s == ch)
                //{
                //    Console.WriteLine("{0}的英文是:{1}",s,ht[s]);
                //}
                if (ht.ContainsKey(ch))
                {
                    Console.WriteLine(ht[ch]);
                    break;
                }
                else
                {
                    Console.WriteLine("抱歉，词库中没有您输入的翻译");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
