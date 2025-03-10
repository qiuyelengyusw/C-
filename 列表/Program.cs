using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Maria", "Jerry" }; // 创建一个列表
            foreach (var name in names) // 遍历列表
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.ReadKey();
        }
    }
}
