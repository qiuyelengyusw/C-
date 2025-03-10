using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 3.14;
            a = (int)b; //强制类型转换
            Console.WriteLine(a);
            Console.ReadKey();

            string strB = "123.456";
            double c = double.Parse(strB); //将字符串转换为double类型
            Console.WriteLine(c);
            Console.ReadKey();

            string strA = "123";
            int d =int.Parse(strA); //将字符串转换为int类型
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
