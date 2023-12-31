using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习六
{
    internal class Program
    {
        //用方法计算一个整数数组的平均值，如果计算的结果有小数，保留2位（四舍五入）
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13 };
            Console.WriteLine("这个数组的平均值是：{0}", getres(ints));
            double a = 123.325;
            Console.WriteLine(a.ToString("F2"));//四舍五入，保留两位小数
            string b = a.ToString("0.00");      //四舍五入，保留两位小数
            double c=Convert.ToDouble(b);       //将保留两位小数的字符串类型再次转换成double类型
            Console.WriteLine(c);
            Console.ReadKey();
        }
        public static double getres(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double res = Math.Round(sum / nums.Length, 2); //Math.Round()方法保留两位小数（四舍五入）
            return res; ;
        }
    }
}
