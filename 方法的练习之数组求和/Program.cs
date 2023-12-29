using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的练习之数组求和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int intSum  = GetSum(nums);
            Console.WriteLine(intSum);
            Console.ReadKey();
        }
        /// <summary>
        /// 求一个整数数组的总和
        /// </summary>
        /// <param name="numbers">需要求和的数组</param>
        /// <returns>返回数组的总和</returns>
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
