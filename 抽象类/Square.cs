using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Square : Shape
    {
        private double _Length;
        public double Length
        {
            get { return _Length; }
            set { _Length = value; }
        }
        private double _wieth;
        public double Wieth
        {
            get { return _wieth; }
            set { _wieth = value; }
        }
        public Square(double length, double wieth)
        {
            this.Length = length;
            this.Wieth = wieth;
        }

        public override double GetArea()
        {
            return this.Length * this.Wieth;
        }

        public override double GetPerimeter()
        {
            return (this.Wieth + this.Wieth) * 2;
        }
    }
}
