using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Student : Teacher
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Student(string name, int age, char gerden, int id) : base(name, age, gerden)
        {
            this.Id = id;
        }
        public void Stu()
        {
            Console.WriteLine("这个是Strudient的方法！");
        }
    }
}
