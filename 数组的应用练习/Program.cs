using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的应用练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region 练习一：从一个整数数组中计算出最大值最小值总和以及平均值
            int[] numsOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int max = numsOne[0];  //int.MinValue;
            int min = numsOne[0];  //int.MaxValue;
            int sum = 0;
            double Average;
            for (int i = 0; i < numsOne.Length; i++)
            {
                if (numsOne[i] > max)
                {
                    max = numsOne[i];
                }
                if (numsOne[i] < min)
                {
                    min = numsOne[i];
                }
                sum += numsOne[i];
            }
            Average =(double) sum / numsOne.Length;
            Console.WriteLine("这个数组中最大的值是:{0}", max);
            Console.WriteLine("这个数组中最小的值是:{0}", min);
            Console.WriteLine("这个数组中所有数的总和是：{0}", sum);
            Console.WriteLine("这个数组中的平均值为：{0}", Average);
            Console.ReadKey();
            #endregion
        }
    }
}
