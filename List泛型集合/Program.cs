using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //创建泛型集合对象
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }); //添加数组
            list.AddRange(list); //添加本身
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]); 
            }
            Console.ReadKey();
            Console.WriteLine("<><><><><><><><><><><>");
            int[] ints = list.ToArray();
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
