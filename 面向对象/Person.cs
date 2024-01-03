using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    internal class Person
    {
        public string _name;
        public int _age;
        public char _gender;

        public void SQ()
        {
            Console.WriteLine("我的名字叫{0},我今年{1}岁，我是{2}生",this._name,this._age,this._gender);
        }

    }
}
