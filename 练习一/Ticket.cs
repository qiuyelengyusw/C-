using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习一
{
    internal class Ticket
    {
        //写一个Ticket类，有一个距离属性（只读，在构造函数中赋值），不能为负数
        //有个价格属性（只读）
        //根据距离distance计算价格price(1元/公里)
        private double _distance;
        //属性
        public double Distance 
        {
            get
            {
                return _distance;
            }
        }
        //构造函数
        public Ticket(double distance) 
        {
            if (distance < 0) 
            {
                distance = 0;
            }
            this._distance = distance;
        }
        private double _price;
        //0-100公里，不打折
        //101-200公里，打9.5折
        //201-300公里，打9折
        //300公里以上打8折
        public double Price
        {
            get
            {
                if (_distance>0 && _distance<=100)
                {
                    return _distance * 1.0;
                }
                else if (_distance>100 && _distance<=200)
                {
                    return _distance * 0.95;
                }
                else if(_distance >200 && _distance<=300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance*0.8;
                }
            }
        }
        //方法
        public void ShowTicker()
        {
            Console.WriteLine("路程{0}公里，票价是{1}元",this.Distance,this.Price);
        }

    }
}
