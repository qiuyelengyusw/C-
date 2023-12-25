using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的应用练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region 练习一：从一个整数数组中计算出最大值最小值总和以及平均值
            int[] numsOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int max = numsOne[0];  //int.MinValue;
            int min = numsOne[0];  //int.MaxValue;
            int sum = 0;
            double Average;
            for (int i = 0; i < numsOne.Length; i++)
            {
                if (numsOne[i] > max)
                {
                    max = numsOne[i];
                }
                if (numsOne[i] < min)
                {
                    min = numsOne[i];
                }
                sum += numsOne[i];
            }
            Average = (double)sum / numsOne.Length;
            Console.WriteLine("这个数组中最大的值是:{0}", max);
            Console.WriteLine("这个数组中最小的值是:{0}", min);
            Console.WriteLine("这个数组中所有数的总和是：{0}", sum);
            Console.WriteLine("这个数组中的平均值为：{0}", Average);
            Console.ReadKey();
            #endregion
            Console.WriteLine("------------------------------------------------"); //输出空行以便于分割练习二
            #region 练习二
            string[] strName = { "钢铁侠", "蜘蛛侠", "绿巨人", "美国队长", "黑寡妇", "鹰眼" };
            string strName1 = null;
            for (int i = 0; i < strName.Length - 1; i++)
            {
                strName1 += strName[i] + "|";
            }
            strName1 += strName[strName.Length - 1];
            Console.WriteLine(strName1);
            Console.ReadKey();
            #endregion
            Console.WriteLine("------------------------------------------------");
            #region 练习三:将一个整数数组的每一个元素进行如下的处理:如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变
            int[] nums = { 1, 2, 3, 4, 5, -2, -6, -7, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i] += 1;
                }
                if (nums[i] < 0)
                {
                    nums[i] -= 1;
                }
                Console.Write(nums[i] + " ");
            }
            Console.ReadKey();
            #endregion
            Console.WriteLine("------------------------------------------------");
            #region 练习四：将一个字符串数组内的元素进行反转
            string[] strA = { "钢铁侠", "蜘蛛侠", "美国队长", "绿巨人", "创世", "分红女巫", "黑寡妇", "鹰眼" };
            for (int i = 0; i < strA.Length / 2; i++) //strA.Length /2 表示数组中元素如果反转，只需要对换的次数是数组中元素个数的1/2
            {
                string temp = strA[i];  //先定义一个变量，将数组的第一个元素暂存到这个变量里，
                strA[i] = strA[strA.Length - 1 - i]; //将对应的元素值赋值给strA[i]
                strA[strA.Length - 1 - i] = temp;   //将暂存的值strA[i],赋值给刚才对应的互换的元素
            }
            for (int i = 0; i < strA.Length; i++)
            {
                Console.Write(strA[i] + " "); //依次输出数组中的元素
            }
            Console.ReadKey();
            #endregion
        }
    }
}
