using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    public class Student
    {
        //构造函数
        public Student(string name,int age,char gender,int chinese,int match,int english) 
        {
            this.Name = name;
            this.Age = age; 
            this.Gender = gender;   
            this.Chinese = chinese;
            this.Match = match;
            this.English = english;
        }
        //构造函数可以有重载,
        public Student(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Student(string name,int chinese,int match,int english):this(name,0,'c',chinese,match,english) 
        {
            //构造函数重载的另外一种写法
        }
        //析构函数，用于立即释放内存，清理垃圾
        ~Student()
        {
            
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get
            {
                if (_age < 0 || _age > 100)
                {
                    _age = 20;
                }
                return _age;
            }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != '男' && value != '女')
                {
                    value = '女';
                }
                _gender = value;
            }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _chinese = value;
            }
        }
        private int _Match;
        public int Match
        {
            get
            {
                if (_Match < 0)
                {
                    _Match = 0;
                }
                return _Match;
            }
            set { _Match = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _english = value;
            }
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0}\n年龄:{1}\n性别:{2}\n我的总成绩是：{3}\n我的平均成绩是:{4}", this.Name, this.Age, this.Gender, this.Chinese + this.Match + this.English, (this.Chinese + this.Match + this.English) / 3);
        }
        public void SayHello() 
        {
            Console.WriteLine("我的名字是:{0},我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }
        public void SayHello2() 
        {
            Console.WriteLine("我叫{0},我的语文成绩是:{1},我的数学成绩是:{2},我的英语成绩是:{3}",this.Name,this.Chinese,this.Match,this.English);
        }
    }
}
