using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\生威的腾讯微云\长城电脑\08-UOS系统间文件共享指南.doc";
            //获得文件名和扩展名            
            Console.WriteLine(Path.GetFileName(str));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件名，不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的路径
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件的绝对路径
            Console.WriteLine(Path.GetFullPath(str));
            //将路径连接到一起
            Console.WriteLine(Path.Combine(@"d:\a\","b.txt"));
            Console.ReadKey();
        }
    }
}
