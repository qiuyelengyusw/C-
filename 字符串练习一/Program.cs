using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace 字符串练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"E:\C#\2.txt";
            //string[] contents = File.ReadAllLines(path);
            //Console.ReadKey();
            //接收用户输入的字符，将其中字符与输入相反的顺序输出
            Console.WriteLine("请输入：");
            string strA = Console.ReadLine();
            //这种方式只是改变了输出，并没有真正改变字符串的内容
            //for (int i = strA.Length-1; i >=0; i--)
            //{
            //    Console.Write(strA[i]);
            //}
            //Console.ReadKey();
            char[] chsA = strA.ToCharArray();
            for (int i = 0; i < chsA.Length / 2; i++)
            {
                char temp = chsA[i];
                chsA[i] = chsA[chsA.Length - 1-i];
                chsA[chsA.Length - 1 - i] = temp;
            }
            strA = new string(chsA);
            Console.WriteLine(strA);
            Console.ReadKey();
            //将一个字符串中的单词反转比如："hello word" 转换成："word hello"
            Console.WriteLine("请输入一句话:");
            string strB = Console.ReadLine();
            string[] newstrB = strB.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < newstrB.Length / 2; i++)
            {
                string temp = newstrB[i];
                newstrB[i] = newstrB[newstrB.Length - 1 - i];
                newstrB[newstrB.Length - 1 - i] = temp;
            }
            strB=string.Join(" ", newstrB);  //将字符串用指定的分隔符连接，这里指定的分隔符是“ ”
            Console.WriteLine(strB);    
            //for (int i = 0; i < newstrB.Length; i++)
            //{
            //    Console.Write(newstrB[i]+" ");
            //}
            Console.ReadKey();
        }
    }
}
