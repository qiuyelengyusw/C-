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
        private string _name; //字段
        public string Name   //属性
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }     

        public void SQ()
        {
            Console.WriteLine("我的名字叫{0},我今年{1}岁，我是{2}生", this.Name, this.Age, this.Gender);
        }

    }
}
