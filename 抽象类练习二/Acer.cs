using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习二
{
    public class Acer:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("这是宏基笔记本");  
        }
    }
}
