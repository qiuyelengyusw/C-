using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比较三个数字的大小2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            Console.WriteLine("请输入第一个数字：");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字：");
            int numberThree = Convert.ToInt32(Console.ReadLine()); 
            #endregion
            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("最大的数字是：{0}", numberOne);
                }
                else
                {
                    Console.WriteLine("最大的数字是：{0}", numberThree);

                }
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine("最大的数字是：{0}", numberTwo);
                }
                else
                {
                    Console.WriteLine("最大的数字是：{0}", numberThree);
                }
            }
            Console.ReadKey();
        }
    }
}
