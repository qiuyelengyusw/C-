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
            Console.ReadKey();
        }
    }
}
