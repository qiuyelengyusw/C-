using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合的练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，将偶数放到另一个集合中
            //将两个集合合并为一个集合，奇数显示在左边，偶数显示在右边
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> LsJiShu = new List<int>();
            List<int> LsOuShu = new List<int>();
            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    LsOuShu.Add(i);
                }
                else
                {
                    LsJiShu.Add(i);
                }
            }
            foreach (int k in LsJiShu)
            {
                Console.Write(k + " ");
            }
            Console.ReadKey();
            Console.WriteLine();
            foreach (int j in LsOuShu)
            {
                Console.Write(j + " ");
            }
            Console.ReadKey();
            List<int> number = new List<int>();
            number.AddRange(LsJiShu);
            number.AddRange(LsOuShu);
            Console.WriteLine();
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
