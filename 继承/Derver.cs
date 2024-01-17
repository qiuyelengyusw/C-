using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Derver
    {
        private int _deryear;
        public int Deryear
        {  
            get { return _deryear; }             
            set { _deryear = value; } 
        }
        public void Der()
        {
            Console.WriteLine("这个是derver的方法！");
        }
    }
}
