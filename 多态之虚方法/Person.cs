using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class Person //父类
    {
        private string _name;
        public string Name 
        {
            get { return _name; } 
            set { _name = value; }
        }
        public  Person(string name) 
        {
            this.Name = name;
        }
        public virtual void SayHello() //关键字virtual虚方法
        {
            Console.WriteLine("我是人类");
        }
    }
}
