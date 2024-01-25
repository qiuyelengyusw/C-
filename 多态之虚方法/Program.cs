using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chinese ch1 = new Chinese("张三");
            Chinese ch2 = new Chinese("李四");
            Japanese jp1 = new Japanese("松下");
            Japanese jp2 = new Japanese("酒井");
            American am1 = new American("John");
            American am2 = new American("Mike");
            Person[] per = {ch1,ch2,jp1,jp2,am1,am2 };
            for (int i = 0; i < per.Length; i++)
                {
                //    if (per[i] is Chinese)
                //    {
                //        ((Chinese)per[i]).SayHello();
                //    }
                //    else if (per[i] is Japanese)
                //    {
                //        ((Japanese)per[i]).SayHello();
                //    }
                //    else
                //    {
                //        ((American)per[i]).SayHello();
                //    }
                per[i].SayHello();
                }
        
            Console.ReadKey();
        }
    }
}
