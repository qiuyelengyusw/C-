using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Derver:Person
    {
        private int _deryear;
        public int Deryear
        {  
            get { return _deryear; }             
            set { _deryear = value; } 
        }
        public Derver(string name,int age,char gerden,int deryear):base(name,age,gerden)
        {
            this.Deryear = deryear;
        }
        public void Der()
        {
            Console.WriteLine("我叫{0},我今年{1}岁，我是{2}生，我的工龄是{3}年",this.Name,this.Age,this.Gerden,this.Deryear);
        }
    }
}
