using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamRead和StreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr=new StreamReader(@"D:\星际争霸秘籍.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
            using (StreamReader sr1 = new StreamReader(@"D:\星际争霸秘籍.txt"))
            {
                while (!sr1.EndOfStream)
                {
                    Console.WriteLine(sr1.ReadLine());
                }
                Console.ReadKey();
            }
            using (StreamWriter sw = new StreamWriter(@"D:\星际争霸秘籍new.txt"))
            {
                sw.WriteLine("这是一个新的文件", true);
            }
            Console.ReadKey();
        }
    }
}
