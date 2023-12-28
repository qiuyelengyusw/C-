using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断用户输入是否正确
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("请输入您的年龄：");
                try
                {
                    int intAge = Convert.ToInt32(Console.ReadLine());
                    if (intAge <= 0 || intAge >100)
                    {
                        Console.WriteLine("您输入的年龄范围不合理!请重新输入！");
                    }
                    else
                    {
                        if (intAge <= 20)
                        {
                            Console.WriteLine("你还是个孩子！");
                        }
                        else if (intAge> 20 &&intAge <=50)
                        {
                            Console.WriteLine("你已经是个成年人了！");    
                        }
                        else
                        {
                            Console.WriteLine("你已经是老年人了！");
                        }
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误！");
                }                
            }
            Console.ReadKey();
        }
    }
}
