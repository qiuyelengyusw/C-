using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace 继承
{
    internal class Person  //将Person作为父类
    {
        private string _name;
        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age 
        { 
            get { return _age; } 
            set { _age = value; }
        }
        private char _gerden;
        public char Gerden
        {
            get { return _gerden; }
            set { _gerden = value; }
        }
        public Person(string name,int age,char gender) //构造函数
        {
            this.Name = name;
            this.Age = age;
            this.Gerden = gender;
        }
        public void Ff()
        {
            Console.WriteLine("这是一个通用的方法！");
        }
    }
}
