using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环之乘法口诀表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j<= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",j,i,i*j);    //Console.Write()语句是只输出不换行               
                }
                Console.WriteLine();//这里用Consoe.Writeline()语句的作用是当每列的口诀输出后，换行
            }
            Console.ReadKey();
        }
    }
}
