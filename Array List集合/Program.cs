using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrs = new ArrayList();   //创建一个集合对象
            //给集合赋值
            arrs.Add(1);
            arrs.Add("姓名");
            arrs.Add('男');
            arrs.Add(3.1514926);
            arrs.Add(true);
            arrs.Add(5000m);
            arrs.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });  //将数组加入到集合中
            Person per = new Person(); //创建Person类的对象
            arrs.Add(per);//将对象放入集合中
            //输出集合的内容
            for (int i = 0; i < arrs.Count; i++)
            {
                if (arrs[i] is Person)  //如果集合中的元素可以转换成父类Person，
                {
                    ((Person)arrs[i]).PersonSayHi();   //就将集合中的元素转换成父类对象
                }
                else if (arrs[i] is int[])  //如果集合中的元素可以转换成整数数组
                {
                    for (int j = 0; j < ((int[])arrs[i]).Length; j++) //遍历转换后的整数数组。并打印输出
                    {
                        Console.Write(((int[])arrs[i])[j] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(arrs[i]);
                }

            }
            Console.ReadKey();
        }
    }
}
