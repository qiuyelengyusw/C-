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
            int[] inta = Getnumbers(ints);  //定义一个数组，接受
            Console.WriteLine("这个数组中最大值是：{0}", inta[0]);
            Console.WriteLine("这个数组中最大值是：{0}", inta[1]);
            Console.WriteLine("这个数组中所有元素的总和是：{0}", inta[2]);
            Console.WriteLine("这个数组的平均值是：{0}", inta[3]);
            Console.ReadKey();
        }
        /// <summary>
        /// 求一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">需要计算的数组</param>
        /// <returns>返回计算的值</returns>
        public static int[] Getnumbers(int[] nums)
        {
            int[] res = new int[4];    //定义一个数组来存储用户给定的数组中计算出来的最大值、最小值、总和与平均值
            res[0] = nums[0];   //max      
            res[1] = nums[0];   //min
            res[2] = 0;         //sum 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];  //最大值
                }
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];  //最小值
                }
                res[2] += nums[i];   //总和
            }
            res[3] = res[2] / nums.Length;       //平均值     
            return res; //返回数组
        }        
    }
}
