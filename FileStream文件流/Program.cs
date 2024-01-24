using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream文件流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用FileStream来读取数据
            FileStream fsread = new FileStream(@"F:\session.log", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            int r = fsread.Read(buffer, 0, buffer.Length);//返回本次实际读取到的有效字节数
            string s = Encoding.Default.GetString(buffer, 0, r); //将字节数组中每一个元素按照指定的编码格式解码成字符串
            //关闭流
            fsread.Close();
            //释放流所占用的资源
            fsread.Dispose();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
