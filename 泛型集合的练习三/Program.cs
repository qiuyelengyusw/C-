using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合的练习三
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //统计 Welcom to china中每个字符出现的次数，不考虑大小写
            string str = "Welcom to China";
            str = str.ToLower();
            str = str.Trim();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)            
            {
                
                if (dic.ContainsKey(str[i])) //如果dic中已经包含了这个键
                {
                    dic[str[i]]++; //将值加1
                }
                else //这个字符在集合中是第一次出现
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (KeyValuePair<char, int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次", kv.Key, kv.Value);
            }
            Console.ReadKey();
        }
    }
}
