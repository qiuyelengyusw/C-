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
                    Console.Write("{0}*{1}={2}\t",j,i,i*j);                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
