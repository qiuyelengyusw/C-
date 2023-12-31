using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写出一个方法，找出下面数组中名字最长的元素
            string[] names = {"卡尔马龙","迈克尔乔丹","邓肯","奥尼尔","科比布莱恩特","奥楚蔑洛夫斯基"};
            string strnamesa=GetLongest (names);
            Console.WriteLine("名字最长的元素是：\n{0}",strnamesa);
            Console.ReadKey();
        }
        /// <summary>
        /// 求数组中最长的元素
        /// </summary>
        /// <param name="names">数组</param>
        /// <returns>返回最长的值</returns>
        public static string GetLongest(string[] names)
        {
            //string strnames = null;
            //for (int i = 0; i < names.Length-1; i++) 
            //{
            //    if (names[i].Length < names[i+1].Length)
            //    {
            //        strnames = names[i+1];
            //    }
            //}
            string strnames = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                if (strnames.Length < names[i].Length)
                {
                    strnames = names[i];    
                }
            }
            return strnames;
        }
    }
}
