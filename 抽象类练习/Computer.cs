using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class Computer
    {
        private MoblesStorage _ms;
        public MoblesStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public Computer(MoblesStorage ms)
        {
            this.Ms = ms;
        }
        public  void CpuRead()
        {
            Ms.Read();
        }
        public  void CpuWrite()
        {
            Ms.Write();
        }
    }
}
