using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序就是将一个数组中的元素按照从小到大或者从大到小的顺序排列
            int[] ints = { 3, 2, 5, 1, 0, 8, 6, 9, 11, 15, 18, 20, 10, 7, 13, 12, 16, 19, 22, 21, 17, 14, 4, 23, 26, 25, 30, 24, 28 };
            for (int i = 0; i < ints.Length - 1; i++)
            {
                for (int j = 0; j < ints.Length - 1 - i; j++)
                {

                    if (ints[j] > ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
