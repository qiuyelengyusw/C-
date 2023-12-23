using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    internal class Program
    {
        public struct Person //结构的声明方法
        {
            public int age; //public 为了让真个程序都能访问到
            public string name;
            public char gender;
        }
        static void Main(string[] args)
        {
            Person zsPerson;
            Console.WriteLine("Please input the first name:");
            zsPerson.name = Console.ReadLine();
            Console.WriteLine("Please input age:");
            zsPerson.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input gender");
            zsPerson.gender =Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Name:{0}\nAge:{1}\ngender:{2}", zsPerson.name, zsPerson.age,zsPerson.gender);
            Console.ReadKey();
        }
    }
}
