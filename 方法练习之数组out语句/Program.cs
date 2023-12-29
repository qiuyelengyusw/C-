using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习之数组out语句
{
    internal class Program
    {
        //用out实现之前求数组最大值、最小值、总和、平均值
        static void Main(string[] args)
        {
            int intmax; //声明变量，存储out返回的最大值
            int intmin;
            int intsum;
            int intavg;
            int[] res = { 1, 2, 3,4,5,6,11,20,-2 };
            GetMaxMinSumAve(res,out intmax,out intmin,out intsum,out intavg); //调用方法
            Console.WriteLine("这个数组中最大值是：{0}",intmax);
            Console.WriteLine("这个数组中最小值是：{0}",intmin);
            Console.WriteLine("这个数组的总和是：{0}",intsum);
            Console.WriteLine("这个数组的平均值是：{0}",intavg);
            Console.ReadKey();
        }
        public static void GetMaxMinSumAve(int[] ins, out int max, out int min, out int sum, out int avg)
        {
            sum = 0;   //这里不能在sum 前面使用int sum ，因为上面的out int sum中已经对sum进行了声明
            max = ins[0];
            min = ins[0];
            for(int i = 0; i < ins.Length; i++) 
            {
                if (ins[i] > max) 
                {
                    max= ins[i];
                }
                if (ins[i] < min) 
                {
                    min= ins[i];    
                }
                sum += ins[i];
            }
            avg = sum/ins.Length;
        }
    }
}
