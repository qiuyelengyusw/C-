using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与总和
            ArrayList list = new ArrayList();
            list.AddRange(new double[] { 1, 2, 3.14, 4.25, 5, 6.36, 7, 8, 9.14 });
            double dblSum = 0;
            for (int i = 0; i < list.Count; i++) 
            {
                dblSum += (int)list[i];
            }
        }
    }
}
