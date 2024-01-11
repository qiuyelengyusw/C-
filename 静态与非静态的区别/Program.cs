using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态的区别
{
    internal class Program
    {
        //非静态类中，可以从对象直接调用非静态方法，但是无法直接调用静态方法，只能通过类名.方法名来调用静态方法
        static void Main(string[] args)
        {
            satic p = new satic();
            p.M1(); //非静态方法调用
            satic.M2(); //类的静态方法调用，
            Console.ReadKey();
        }
    }
}
