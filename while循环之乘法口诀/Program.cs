using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环之乘法口诀
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //这里面采用while循环的额嵌套来实现长发口诀的打印输出，先比较这下，用for循环语句会更简洁一些
            int i = 1;
            while(i < 10) 
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("{0}*{1}={2}\t",j,i ,i*j);  //“\t”的作用是输出空格
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
