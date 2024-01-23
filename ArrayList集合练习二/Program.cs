using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合练习二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写一个长度为10的集合，要求在里面随机的放10个数字（0-9）
            //要求所有的数字不重复
            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++) 
            {
                int number=r.Next(0,10);
                if(!list.Contains(number))  //如果集合中没有这个随机数
                {
                    list.Add(number);     //将这个随机数添加到集合中
                }
                else //如果集合中已经存在相同的随机数
                {
                    i--; //将I-1，重新计算循环次数
                }
            }
            for (int i = 0;i < list.Count;i++) 
            {
                Console.Write(list[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
