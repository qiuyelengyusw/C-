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
            int[] nums1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //数组的一种声明方式
            for (int j = 0; j < nums1.Length; j++)
            {
                nums1[j] = j;
                Console.WriteLine(nums1[j]);
            }
            for (int k = nums1.Length - 1; k >= 0; k--) //使用for循环倒序输出数组的值
            {
                nums1[k] = k;
                Console.WriteLine(nums1[k]);

            }
            Console.WriteLine(nums1[1]);
            int[] nums = new int[100]; //这行代码用另一种声明方式，声明了一个长度是10的整数类型的数组
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
            }
            int[] nums2 = new int[] { 1, 2, 3 };
            Console.WriteLine(nums2[0]);

            Console.ReadKey();
        }
    }
}
