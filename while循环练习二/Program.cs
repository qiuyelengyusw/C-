using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数，然后依次输入同学成绩，最后计算班级的总成绩和平均成绩
            int intNumber = 0;            
            int intSum = 0;
            int i = 1;             
            Console.WriteLine("请输入班级人数：");
            intNumber = int.Parse(Console.ReadLine());
            while(i <= intNumber) 
            {
                Console.WriteLine("请输入第{0}位同学的成绩：",i);
                intSum += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("这个班级的总成绩为：{0},平均成绩为：{1}",intSum,intSum/intNumber);
            Console.ReadKey();  
        }
    }
}
