using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class Chinese:Person
    {
        public Chinese(string name):base(name) 
        {
        }
        public override void SayHello()  //关键字ovberride
        {
            Console.WriteLine("我是中国人，我的名字是:{0}",this.Name);
        }
    }
}
