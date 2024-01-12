using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 构造函数;
namespace 面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pername = new Person();    //创建类的对象
            pername.Name = "张三"; //给类的对象赋值的过程叫做对象的初始化
            pername.Age = -19;
            pername.Gender = '中';
            pername.SQ();      //调用类
            Console.ReadKey();
            Person per1 = new Person();
            per1.Name = "李四";
            per1.Age = 19;
            per1.Gender = '女';
            per1.SQ();
            Console.ReadKey();

            Student k = new Student("王五",18,'男');
            k.ShowScore();
        }
    }
}
