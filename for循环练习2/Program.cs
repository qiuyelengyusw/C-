using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环练习2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数:");
            string strNumber = Console.ReadLine(); 
            int intNumber = Convert.ToInt32(strNumber);
            for (int i = 0; i <=intNumber; i++)
            {
                Console.WriteLine("{0} + {1} = {2}",i,intNumber-i,intNumber);
            }
            Console.ReadKey();
        }
    }
}
