using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合的长度
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);    
            list.Add(4);
            Console.WriteLine(list.Count); //这个集合中实际包含的元素的个数
            Console.WriteLine(list.Capacity);//这个集合中可以包含的元素的个数
            //每次集合中实际包含的元素的个数（Count）超过了可以包含的元素的个数（Capcity）的时候，集合就会向内存申请多开辟一倍的空间，来保证集合的长度一直够用
            Console.ReadKey();
        }
    }
}
