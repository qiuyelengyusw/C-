using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //不断要求用户输入一个数字，然后打印这个数字的两倍，知道用户输入q的时候程序退出
            string strNumber;
            double dlbNumber;
            do
            {
                Console.WriteLine("请输入一个数字：");
                strNumber = Console.ReadLine();
                if (strNumber == "q")
                {
                    break;
                }
                dlbNumber = Convert.ToDouble(strNumber);
                Console.WriteLine(dlbNumber*2);
            } while (strNumber!="q");
            Console.WriteLine("请按任意键推出程序");
            Console.ReadKey();  
        }
    }
}
