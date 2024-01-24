using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个新文件
            //File.Create(@"E:\new.txt");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();
            //删除文件
            //File.Delete(@"E:\new.txt");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();
            //复制文件
            //File.Copy(@"E:\new.txt", @"E:\new1.txt");
            //Console.WriteLine("复制文件成功");
            //Console.ReadKey();
            //将内容写进文本文件中
            string str = "把所有想的念的错的痛的都放在心脏，行李箱里装不下我想去的远方。";
            byte[] buffer = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"E:\new.txt", buffer);
            Console.WriteLine("写入成功");
            Console.ReadKey();
            //已行的形式读出文件中的内容
            string[] stra = File.ReadAllLines(@"E:\new.txt", Encoding.Default);
            foreach (string str2 in stra)
            {
                Console.WriteLine(str2);
            }
            Console.ReadKey();
            string strb = File.ReadAllText(@"E:\new.txt", Encoding.Default);
            Console.WriteLine(strb);
            Console.ReadKey();
            File.WriteAllLines(@"E:\new1.txt", new string[] { "从来都没有", "一个人像你爱我这么久" });
            Console.WriteLine("写入成功");
            Console.ReadKey();
            File.WriteAllText(@"E:\new.txt", "这个是新写入的内容", Encoding.Default);
            Console.WriteLine("重新写入成功");
            Console.ReadKey();
            File.AppendAllLines(@"E:\new.txt", new string[] { "\nAppendAllLined追加的文件"},Encoding.Default);
            Console.WriteLine("追加内容成功");
            Console.ReadKey();
            File.AppendAllText(@"E:\new.txt","AppendAllText追加的内容",Encoding.Default);
            Console.WriteLine("追加内容成功");
            Console.ReadKey();            
        }
    }
}
