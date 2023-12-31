using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习四
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的成绩：");           
           // GetCj(GetIsDouble(Console.ReadLine()));
            string s = GetLevel(GetIsDouble(Console.ReadLine()));
            Console.WriteLine(s);   
            Console.ReadKey();

        }
        /// <summary>
        /// 返回正确的成绩
        /// </summary>
        /// <param name="s">用户输入的内容</param>
        /// <returns>返回double成绩</returns>
        public static double GetIsDouble(string s)
        {          
            while (true) 
            {
                try
                {
                    double strs = Convert.ToDouble(s);                                      
                    return strs;
                }
                catch
                {
                    Console.WriteLine("输入错误，请输入一个数字：");
                    s=Console.ReadLine();
                }
                
            }

        }
        /// <summary>
        /// 判断成绩的档次
        /// </summary>
        /// <param name="dbla">输入的成绩</param>
        public static void  GetCj(double dbla)
        {           
            switch (Math.Round( dbla / 10))
            {
                case 9:
                    Console.WriteLine("优");
                    break;
                case 8:
                    Console.WriteLine("良");
                    break;
                case 7:
                    Console.WriteLine("中");
                    break;
                case 6:
                    Console.WriteLine("及格");
                    break;
                case 5:
                    Console.WriteLine("差");
                    break;
                case 4:
                    Console.WriteLine("差");
                    break;
                case 3:
                    Console.WriteLine("差");
                    break;
                case 2:
                    Console.WriteLine("差");
                    break;
                case 1:
                    Console.WriteLine("差");
                    break;
                case 0:
                    Console.WriteLine("傻子");
                    break;
            }
        }
        public static string GetLevel(double score)
        {
            //string  level = null;
            switch (score/10) 
            {
                case 9:
                    return "优";
                case 8:
                    return "良";
                case 7:
                    return "中";
                case 6:
                    return "及格";
                default: return "不及格";
            }
        }
    }
}
