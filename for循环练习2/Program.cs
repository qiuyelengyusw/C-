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
            int intNumber=0;           
            string strNumber;           
            while (true) 
            {
                Console.WriteLine("请输入一个数字:");
                strNumber = Console.ReadLine();
                if (int.TryParse(strNumber, out intNumber))
                {
                    if (Convert.ToInt32(strNumber) > 0)
                    {
                        intNumber = Convert.ToInt32(strNumber);
                        break;                       
                    }
                    else
                    {
                        Console.WriteLine("输入的数字不能小于或者等于0！");
                    }
                }
                else
                {
                    Console.WriteLine("输入错误，请重新输入！");
                   
                }
            }
            for (int i = 0; i <= intNumber; i++)
            {
                Console.WriteLine("{0} + {1} = {2}",i,intNumber-i,intNumber);
            }
            Console.ReadKey();
        }
    }
}
