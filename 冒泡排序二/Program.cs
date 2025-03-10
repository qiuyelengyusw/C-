using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序二
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints1 = { 3, 2, 5, 1, 0, 8, 6, 9, 11, 15, 18, 20, 10, 7, 13, 12, 16, 19, 22, 21, 17, 14, 4, 23, 26, 25, 30, 24, 28, 27, 50 }; //定义一个数组
            for (int i = 0; i < ints1.Length + 1; i++) //外层循环控制排序趟数
            {
                for (int j = 0; j < ints1.Length - 1 - i; j++) //内层循环控制每一趟排序多少次
                {
                    if (ints1[j] < ints1[j + 1]) // 如果前一个元素大于后一个元素，则交换两个元素的位置
                    {
                        int temp = ints1[j];
                        ints1[j] = ints1[j + 1];
                        ints1[j + 1] = temp;
                    }
                }
            }
            Console.ReadLine();
            for (int i = 0; i < ints1.Length; i++)
            {
                Console.Write(ints1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
