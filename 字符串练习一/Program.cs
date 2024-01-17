using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace 字符串练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\2.txt";
            string[] contents = File.ReadAllLines(path);
            for (int i = 0; i < contents.Length; i++)
            {
                string[] strE = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                strE[0] = strE[0].Length > 4 ? strE[0].Substring(0, 5) + "......" : strE[0];
                Console.WriteLine(string.Join("|", strE));
            }
            Console.ReadKey();

            //接收用户输入的字符，将其中字符与输入相反的顺序输出
            Console.WriteLine("请输入：");
            string strA = Console.ReadLine();
            //这种方式只是改变了输出，并没有真正改变字符串的内容
            //for (int i = strA.Length-1; i >=0; i--)
            //{
            //    Console.Write(strA[i]);
            //}
            //Console.ReadKey();
            char[] chsA = strA.ToCharArray();
            for (int i = 0; i < chsA.Length / 2; i++)
            {
                char temp = chsA[i];
                chsA[i] = chsA[chsA.Length - 1 - i];
                chsA[chsA.Length - 1 - i] = temp;
            }
            strA = new string(chsA);

            Console.WriteLine(strA);
            Console.ReadKey();
            //将一个字符串中的单词反转比如："hello word" 转换成："word hello"
            Console.WriteLine("请输入一句话:");
            string strB = Console.ReadLine();
            string[] newstrB = strB.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < newstrB.Length / 2; i++)
            {
                string temp = newstrB[i];
                newstrB[i] = newstrB[newstrB.Length - 1 - i];
                newstrB[newstrB.Length - 1 - i] = temp;
            }
            strB = string.Join(" ", newstrB);  //将字符串用指定的分隔符连接，这里指定的分隔符是“ ”
            Console.WriteLine(strB);
            //for (int i = 0; i < newstrB.Length; i++)
            //{
            //    Console.Write(newstrB[i]+" ");
            //}

            //从email中提取用户名和域名
            string email = "qiuyelengyu@qq.com";
            int index = email.IndexOf("@");
            string username = email.Substring(0, index);
            string Yuming = email.Substring(index + 1);
            Console.WriteLine(username);
            Console.WriteLine(Yuming);
            Console.ReadKey();
            //从用户输入的话中，找出所有e的位置
            //方法一：
            Console.WriteLine("请输入一段包含字母e的英文语句：");
            string strF = Console.ReadLine();
            int indexA = strF.IndexOf("e");
            Console.WriteLine("第1次出现e的位置是{0}", indexA);
            int count = 1;//用来记录e出现的次数
            while (indexA != -1) //indexA=-1表示已经找到了最后
            {
                count++;
                indexA = strF.IndexOf("e", indexA + 1);
                if (indexA == -1) //判断如果indexA=-1的时候跳出循环，不在执行下面的语句，否则会输出indexA=-1的语句
                {
                    break;
                }
                Console.WriteLine("第{0}次出现e的位置是{1}", count, indexA);
            }
            Console.ReadKey();
            //方法二：
            Console.WriteLine("请输入一段包含字母e的英文语句：");
            string strG = Console.ReadLine();
            int countB = 1;
            for (int i = 0; i < strG.Length; i++) 
            {
                if (strG[i] =='e')
                {                    
                    Console.WriteLine("第{0}次出现e的位置是{1}",countB,i);
                    countB++;
                }               
            }
            Console.ReadKey();


            //判断用户输入是否包含有某个特定词，如果有的话，将这个字符转换成“**”
            Console.WriteLine("请输入一句话:");
            string strH= Console.ReadLine();    
            if(strH.Contains("邪恶"))
            {
               strH = strH.Replace("邪恶","****");
            }
            Console.WriteLine(strH);
            Console.ReadKey ();

            //将{"乔丹",“奥尼尔”,"卡特","科比布莱恩特"}变成乔丹|奥尼尔|卡特|科比布莱恩特，然后再把|切割掉
            string[] names = { "乔丹", "奥尼尔", "卡特", "科比布莱恩特" };
            string namesA=string.Join("|", names);
            Console.WriteLine(namesA);
            //namesA = namesA.Replace("|", ",");
            string[] namesB =namesA.Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < namesB.Length; i++)
            {
                Console.Write(namesB[i]);
            }
            Console.WriteLine();
            //Console.WriteLine(namesA);  
            Console.ReadKey ();
        }
    }
}

