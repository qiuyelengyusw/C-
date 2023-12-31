using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习三
{
    internal class Program
    {
        //用方法实现计算一个整数数组的平均值,并保留两位小数
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,12};
            double avg = GetAvg(ints);
            Console.WriteLine(avg); 
            Console.ReadKey();
        }
        /// <summary>
        /// 求整数数组的平均值
        /// </summary>
        /// <param name="intsa">数组</param>
        /// <returns>返回平均值</returns>
        public static double GetAvg(int[] intsa)
        {
            int sum = 0;
            for (int i = 0; i < intsa.Length; i++) 
            {
                sum += intsa[i];    
            }
            return Math.Round((double) sum/intsa.Length,2);
        }
    }
}
