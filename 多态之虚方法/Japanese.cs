using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class Japanese:Person
    {
        public Japanese(string namne):base(namne) 
        {
        }
        public override void SayHello()//关键字ovberride
        {
            Console.WriteLine("我是日本人，我的名字是{0}",this.Name);
        }
    }
}
