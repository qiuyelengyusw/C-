using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //模拟将U盘、MP3、移动硬盘查到电脑上读取数据的过程
            MoblesStorage st = new Mp3();//new UDisk();
            Computer cp =new Computer(st);
            cp.CpuRead();
            cp.CpuWrite();
            Console.ReadKey();

        }
    }
}
