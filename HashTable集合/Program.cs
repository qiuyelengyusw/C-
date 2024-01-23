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
            ht[7] = "通过键添加值";
            ht[2] = "替换原来的张三"; //通过这种添加值的方式，可以将集合中原来对应键的值替换成新的值
            ht.Add(6,"张三");  //Hashtable集合中，键不可以重复，但是值可以重复
            ht.Remove(3); //移除集合中指定键的值
            if(!ht.ContainsKey(5)) //向集合中添加数值的时候，先判断这个集合中是否已经存在相同的键
            {
                ht.Add(5,"李四");
            }
            else
            {
                Console.WriteLine("这个集合中已经包含这个键！！！");
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("{0}>>>>>>>>>>>>>>>>>>>>>{1}", item, ht[item]);
            }
            Console.ReadKey();
            ht.Clear();//移除集合中所有元素
        }
    }
}
