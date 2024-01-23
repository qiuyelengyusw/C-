using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); //创建键值对集合对象
            ht.Add(1, 1);
            ht.Add(2, "张三");
            ht.Add(3, true);
            ht.Add(4, 3.14);
            ht.Add(5, '男');
            ht.Add(false, "错误");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("{0}>>>>>>>>>>>>>>>>>>>>>{1}", item, ht[item]);
            }
            Console.ReadKey();
        }
    }
}
