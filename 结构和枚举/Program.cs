using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构和枚举
{
    class Program
    {
        public struct Person 
        {
            public string _Name;
            public int _Age;
            public Gender _Gender;
        }
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            Person zsperson;
            zsperson._Name = "张三";
            zsperson._Age = 20;
            zsperson._Gender = Gender.男;
            Console.WriteLine($"姓名：{zsperson._Name}，年龄：{zsperson._Age}，性别：{zsperson._Gender}"); // 姓名：张三，年龄：20，性别：男
            Console.WriteLine("姓名：{0}，年龄：{1}，性别：{2}", zsperson._Name, zsperson._Age, zsperson._Gender); // 姓名：张三,年龄：20,性别：男);
            Console.ReadKey();
            Person lsperson;
            lsperson._Name = "李四";
            lsperson._Age = 18;
            lsperson._Gender = Gender.女;
            Console.WriteLine($"姓名：{lsperson._Name}，年龄：{lsperson._Age}，性别：{lsperson._Gender}"); // 姓名：李四，年龄：18，性别：女
            Console.WriteLine("姓名：{0}，年龄：{1}，性别：{2}", lsperson._Name, lsperson._Age, lsperson._Gender); // 姓名：李四,年龄：18,性别：女);
            Console.ReadKey();
        }
    }
}
