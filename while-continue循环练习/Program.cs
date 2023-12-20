using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_continue循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 1;
            int intSum = 0;

            //下面使用while循环实现1到100之间，不能被7整除的所有整数的和
            while (intNumber <= 100 )
            {
                if (intNumber % 7 != 0)
                {
                    intSum += intNumber;
                }               
                intNumber++;
            }

            //下面使用while continue循环语句实现上面的功能
            
            //while (intNumber <= 100) 
            //{
            //    if (intNumber % 7 == 0) 
            //    {
            //        intNumber++;
            //        continue;
            //    }
            //    intSum += intNumber;
            //    intNumber++;
            //}
            Console.WriteLine(intSum);
            Console.ReadKey();
        }
    }
}
