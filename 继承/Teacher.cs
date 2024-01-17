using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Teacher : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Teacher(string name, int age, char gerden, double salary) : base(name, age, gerden)
        {

            this.Salary = salary;
        }

        public Teacher(string name, int age, char gender) : base(name, age, gender)
        {
        }

        public void Tea()
        {
            Console.WriteLine("这个是Teacher的方法！");
        }
    }
}
