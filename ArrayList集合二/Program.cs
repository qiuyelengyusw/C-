using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayList集合二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(true);
            list.Add("张三");
            //添加集合元素
            list.AddRange(new string[] { "李四", "王五", "赵六" });
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list); //添加集合元素
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
