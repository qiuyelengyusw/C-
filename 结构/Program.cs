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
            public int _age; //public 为了让真个程序都能访问到
            public string _name;
            public char _gender;
        }
        static void Main(string[] args)
        {
            Person zsPerson;
            Console.WriteLine("Please input the first name:");
            zsPerson._name = Console.ReadLine();
            Console.WriteLine("Please input age:");
            zsPerson._age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input gender");
            zsPerson._gender =Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Name:{0}\nAge:{1}\ngender:{2}", zsPerson._name, zsPerson._age,zsPerson._gender);
            Console.ReadKey();
        }
    }
}
