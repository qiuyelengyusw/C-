using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("张三",25,'男',3000);
            teacher.Tea();
            Console.ReadKey();
            Student student= new Student("李四",20,'女',001);
            student.Stu();
            student.Tea();
            student.Ff();
            Console.ReadKey();
            Derver der = new Derver("王五", 36, '男', 15);
            der.Der();
            Console.ReadKey ();
        }
    }
}
