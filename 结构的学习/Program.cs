using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构的学习
{
    internal class Program
    {
        public struct Person
        {
            public int _age;
            public string _name;
            public char _gerden;
        }
        static void Main(string[] args)
        {
            Person firstPerson;
            Console.WriteLine("Please input the first name:");
            firstPerson._name = Console.ReadLine();
            Console.WriteLine("Please input the first age:");
            firstPerson._age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please input the first gerden:");
            firstPerson._gerden = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("The first name is:{0}\nThe first age is:{1}\nThe first gerden is:{2}",firstPerson._name,firstPerson._gerden,firstPerson._age);
            Console.ReadKey();  
        }
    }
}
