using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class American:Person
    {
        public American(string name):base(name)
        {
        }
        public override void SayHello() //关键字ovberride
        {
            Console.WriteLine("我是美国人，我的名字叫{0}",this.Name);
        }
    }
}
