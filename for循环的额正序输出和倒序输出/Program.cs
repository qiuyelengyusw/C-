using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环的额正序输出和倒序输出
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 打印输出1到100
            for (int i = 1; i < 101; i++)

            {
                Console.WriteLine(i);
            }
            #endregion
            for (int i = 99; i > 0; i--) //倒叙打印输出
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
