using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(100,100));
            Console.WriteLine(Test("Hello","word"));
            Console.WriteLine(Test(100,100,100));
            Console.WriteLine(Test(3.14,2.97));
            Console.ReadKey();
        }
        //下面4个方法用同样的方法名，但是参数数量一样的情况下，参数类型不能相同，参数类型相同的情况下，参数数量不能相同
        public static string Test(string stra, string strb)
        {
            return stra + strb;
        }
        public static int Test(int a, int b)        
        { 
            return a + b;
        }
        public static int Test(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Test(double a, double b)
        {
            return a + b;
        }
    }
}
