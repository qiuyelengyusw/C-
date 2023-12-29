using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习之数组
{
    internal class Program
    {
        //写一个方法，求一个数组中的最大值，最小值，总和、平均值
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, -9, 0,15};
            int[] inta = Getnumbers(ints);
            for (int i = 0; i < inta.Length; i++)
            {
                Console.WriteLine(inta[i]);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 求一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">需要计算的数组</param>
        /// <returns>返回计算的值</returns>
        public static int[] Getnumbers(int[] nums)
        {
            int[] res = new int[4];
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            int average;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            average = sum / nums.Length;
            res[0] = max;
            res[1] = min;
            res[2] = sum;
            res[3] = average;
            return res;
        }
    }
}
