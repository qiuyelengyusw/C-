using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicitionary泛型集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王五");
            dic[4] = "赵六";
            foreach (var item in dic.Keys)
            {
                Console.Write(dic[item] + " ");
            }
            Console.ReadKey();
            Console.WriteLine();
            foreach (KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine(kv.Key + ">>>>>>>>>>>" + kv.Value);
            }
            Console.ReadLine();
        }
    }
}
