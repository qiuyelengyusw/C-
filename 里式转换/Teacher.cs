using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里式转换
{
    internal class Teacher:Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("I'm Teacher");
        }
    }
}
