using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用多态，求圆形和矩形的面积和周长
            //1、元的面积和周长
            Shape sp = new Circle(6);
            double area = Math.Round(sp.GetArea(), 2);
            double shap = Math.Round(sp.GetPerimeter(), 2);
            Console.WriteLine("这个圆形的面积是：{0},周长是：{1}",area,shap);
            Console.ReadKey();
            //2、矩形的面积和周长
            Shape sq = new Square(6, 4);
            double areasq=sp.GetArea();
            double shapsq =sp.GetPerimeter();
            Console.WriteLine("这个矩形的面积是:{0}\n这个矩形的周长是:{1}",areasq,shapsq);
            Console.ReadKey();
        }
    }
}
