using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 创建仓库的时候，向仓库中添加货架（使用嵌套集合的方法）
    /// </summary>
    internal class Warehouse
    {
        List<List<commodity>> listCommodity = new List<List<commodity>>();
        public Warehouse() //构造函数
        {
            //向仓库中添加货架
            listCommodity.Add(new List<commodity>());
            listCommodity.Add(new List<commodity>());
            listCommodity.Add(new List<commodity>());
            listCommodity.Add(new List<commodity>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strTyep">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void InCommodity(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "联想":
                        listCommodity[0].Add(new Lenovo(Guid.NewGuid().ToString(),"联想电脑", 1000, 7000)); //编号，名称，数量，价格
                        break;
                    case "香蕉":
                        listCommodity[1].Add(new Banana(Guid.NewGuid().ToString(),"香蕉", 1500, 5));
                        break;
                    case "西红柿":
                        listCommodity[2].Add(new Tomato(Guid.NewGuid().ToString(),"西红柿", 1300, 6));
                        break;
                    case "三星":
                        listCommodity[3].Add(new SamSung(Guid.NewGuid().ToString(),"三星手机", 6835, 200));
                        break;
                }
            }
        }
        public commodity[] OutCommodity(string strType, int count)
        {
            commodity[] com = new commodity[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "联想":
                        com[i] = listCommodity[0][0];
                        listCommodity[0].RemoveAt(0);
                        break;
                    case "香蕉":
                        com[i] = listCommodity[1][0];
                        listCommodity[1].RemoveAt(0);
                        break;
                    case "西红柿":
                        com[i] = listCommodity[2][0];
                        listCommodity[2].RemoveAt(0);
                        break;
                    case "三星":
                        com[i] = listCommodity[3][0];
                        listCommodity[3].RemoveAt(0);
                        break;
                }
            }
            return com;
        }   
    }
}
