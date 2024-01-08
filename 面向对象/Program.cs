using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pername = new Person();    //声明一个类
            pername.Name = "张三";
            pername.Age = 19;
            pername.Gender = '男';
            pername.SQ();      //调用类
            Console.ReadKey();
        }
    }
}
