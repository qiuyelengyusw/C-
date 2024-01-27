using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class MoveDisk : MoblesStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
}
