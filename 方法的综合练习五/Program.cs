using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的综合练习五
{
    internal class Program
    {
        //将字符串数字的元素翻转
        static void Main(string[] args)
        {
            string[] stra = { "中国", "美国", "德国", "澳大利亚", "英国", "日本" };
            GetFZ(stra);
            Console.ReadKey();
        }
        /// <summary>
        /// 将一个字符串数组翻转
        /// </summary>
        /// <param name="s">字符串数组</param>
        public static void GetFZ(string[] s)
        {
            for (int i = 0; i < s.Length/2; i++) 
            {
                string tep = s[i];
                s[i] = s[s.Length-1-i];
                s[s.Length-1-i] = tep;
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]+" ");
            }
        }
               
    }
}
