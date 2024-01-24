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
            //使用FileStream来写入数据
            using (FileStream fswrite = new FileStream(@"F:\session1.log", FileMode.OpenOrCreate, FileAccess.Write)) //使用using()目的是让程序自动释放流占用的资源，可以省略.close()和.Dispose()语句
            {
                string str = "这是写入的数据";
                byte[] buffer1 = Encoding.Default.GetBytes(str);
                fswrite.Write(buffer1, 0, buffer1.Length);
            }
            Console.WriteLine("数据已写入");
            Console.ReadKey();
            //使用FileStream实现多媒体文件的复制
            string source = @"D:\音乐\蒙娜丽莎的眼泪.ape";
            string target = @"F:\蒙娜丽莎的眼泪new.ape";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
        /// <summary>
        /// 读取和写入的方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public static void CopyFile(string source, string target) 
        {
            //创建一个负责读取的流
            using (FileStream fsread = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fswrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //文件可能会比较大，需要通过循环读取
                    while (true)
                    {
                        //返回本次实际读取到的字节数
                        int r = fsread.Read(buffer, 0, buffer.Length);
                        //如果r返回0，则说明读取完毕
                        if (r == 0)
                        {
                            break;
                        }
                        fswrite.Write(buffer, 0, r);
                    }
                }

            }

        }
    }
}
