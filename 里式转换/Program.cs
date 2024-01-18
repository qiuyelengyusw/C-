using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[10]; //定义一个person父类的数组，存放子类
            Random r = new Random();  //随机数
            for (int i = 0; i < pers.Length; i++) 
            {
                int ran=r.Next(1,7);
                switch (ran) //1-6   //利用随机数给Person[]数组赋值
                {
                    case 1:
                        pers[i]=new Person();
                        break;
                    case 2:
                        pers[i]=new Teacher();
                        break;
                    case 3:
                        pers[i]=new Student();
                        break;
                    case 4:
                        pers[i]=new SB();
                        break;
                    case 5:
                        pers[i]=new TianCai();
                        break;
                    case 6:
                        pers[i] = new Child();
                        break;
                }
            }
            for (int i = 0;i < pers.Length;i++) 
            {
                if (pers[i] is Student)    //如果父类pers[i]可以转换为子类Student
                {
                    ((Student)pers[i]).StudentSayHi();   //调用Student子类的方法
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();
                }
                else if (pers[i] is SB)
                {
                    ((SB)pers[i]).SBSayHi();
                }
                else if ((pers[i] is Child))
                {
                    ((Child)pers[i]).ChildSayHi();
                }
                else
                {
                    pers[i].PersonSayHi();
                }
            }
            Console.ReadKey();
        }
    }
}
