using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序就是将一个数组中的元素按照从小到大或者从大到小的顺序排列
            int[] ints = { 3, 2, 5, 1, 0, 8, 6, 9, 11, 15, 18, 20, 10, 7, 13, 12, 16, 19, 22, 21, 17, 14, 4, 23, 26, 25, 30, 24, 28 };
            int[] ints1 = { 3, 2, 5, 1, 0, 8, 6, 9, 11, 15, 18, 20, 10, 7, 13, 12, 16, 19, 22, 21, 17, 14, 4, 23, 26, 25, 30, 24, 28, 27, 50 };
            #region 方法一：使用自带函数快速排序
            //
            Array.Sort(ints1);  //Array.Sort() 只能对数组进行升序排列
            Array.Reverse(ints1); //翻转数组，配合上面的Sort，可实现数组的降序排列

            for (int i = 0; i < ints1.Length; i++)
            {
                Console.WriteLine(ints1[i] + " ");
            }
            #endregion
            #region 方法二：使用for循环嵌套的方法
            for (int i = 0; i < ints.Length - 1; i++)  //外层循环控制排序趟数
            {
                for (int j = 0; j < ints.Length - 1 - i; j++) //内层循环控制每一趟排序多少次
                {

                    if (ints[j] > ints[j + 1]) //如果前一个元素大于后一个元素，则交换两个元素的位置
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i] + " ");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
