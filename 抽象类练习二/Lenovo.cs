using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习二
{
    public class Lenovo : NoteBook
    {       

        public override void SayHello()
        {
            Console.WriteLine("这是联想笔记本");
        }
    }
}
