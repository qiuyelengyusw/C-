using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class commodity //商品父类
    {
        public double Price //价格
        {
            get;
            set;
        }
        public double Count //数量
        {
            get;
            set;
        }
        public string ID   //编号
        {
            get;
            set;
        }
        public string Name //名称
        {
            get;
            set;
        }
        public commodity(string id, string name, double count, double price)
        {
            this.Price = price;
            this.ID = id;
            this.Count = count;
        }
    }
}
