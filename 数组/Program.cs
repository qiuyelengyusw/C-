using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; //这行代码声明了一个长度是10的整数类型的数组
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine();
            //数组的第二种声明方法
            int[] numsTwo = new int[5] { 1, 2, 3, 4, 5 };
            for (int j = numsTwo.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(numsTwo[j]);  
            }
            Console.ReadKey();
        }
    }
}
