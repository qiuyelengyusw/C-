using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初步认识结构
{
    internal class Program
    {
        public struct Person //声明一个结构，并且声明里面的字段
        {
            public int _Age;
            public string _Name;
            public char _Gender;
        }
        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._Name = "张三";
            zsPerson._Gender = '男';
            zsPerson._Age = 20;

            Person lsPerson;
            lsPerson._Gender = '男';
            lsPerson._Age = 25;
            lsPerson._Name = "李四";
            Console.WriteLine(zsPerson._Name,zsPerson._Gender,zsPerson._Age);
            Console.ReadKey();
        }
    }
}
