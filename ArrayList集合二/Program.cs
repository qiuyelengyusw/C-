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
            list.Sort();          //按照升序排列集合
            list.Reverse();       //反转集合中的元素
            list.Insert(0, "插入的0");  //在指定的下标插入元素
            list.InsertRange(2, new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });   //在指定的位置插入集合
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //list.Clear();清除集合中所有元素
            list.Remove(true);    //删除集合中的元素
            list.RemoveAt(0); //根据索引下标删除集合中的元素
            list.RemoveRange(0, 2); //从指定的索引下标开始，删除一定范围内的元素
            Console.ReadKey();
        }
    }
}
