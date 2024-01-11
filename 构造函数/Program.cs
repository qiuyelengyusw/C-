using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //如果用下面的代码给对象初始化，会产生重复代码，并且数据量会很大
            //Student Zs = new Student();
            //Zs.Name = "张三";
            //Zs.Age = -18;
            //Zs.Gender = '男';
            //Zs.Chinese = 100;
            //Zs.Match = 100;
            //Zs.English = 100;
            //Zs.ShowScore();
            //Console.WriteLine();
            //Student Ls = new Student();
            //Ls.Name = "李四";
            //Ls.Age = 18;
            //Ls.Gender = '中';
            //Ls.Chinese = 90;
            //Ls.Match = 70;
            //Ls.English = 85;
            //Ls.ShowScore();
            //Console.ReadKey();

            //采用构造函数
            Student Zs = new Student("张三",-15,'男',100,100,100);
            Zs.ShowScore();
            Console.WriteLine();
            Zs.SayHello2();
            Console.WriteLine();
            Student Ls = new Student("李四",19,'中',85,95,90);
            Ls.ShowScore(); 
            Ls.SayHello(); //构造函数的重载
            Console.ReadKey();
        }
    }
}
