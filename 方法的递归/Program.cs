using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的递归
{
    internal class Program
    {
        public static int i = 0; //定义一个全局字段，用于下面的方法，全局字段的值不可变，只用用于给方法中的I赋初值
        static void Main(string[] args)
        {
            TellStory();   //调用方法
            Console.ReadKey();
        }
        public static void TellStory()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚");
            Console.WriteLine("老和尚对小和尚说：");
            i++; //方法每递归一次，I的值就加1
            if (i == 10)
            {
                return;    //方法递归循环10次的时候，跳出方法；
            }
            TellStory(); //方法自己调用自己，实现方法的递归
        }
    }
}
