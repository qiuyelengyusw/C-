using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态的区别
{
    public class satic
    {
        private static string _name;
        public static string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public void M1()
        {
            Console.WriteLine("我是非静态的方法");
        }
        public static void M2() 
        {
            Console.WriteLine("我是一个静态方法");
        }
    }
}
