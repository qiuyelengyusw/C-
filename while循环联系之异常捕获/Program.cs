

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环联系之异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 0;//定义一个初始值为0的整型变量，用于存储班级的人数；
            int intgrades = 0;//定义一个初始值为0的整型变量，用于存储每个学员的成绩；
            int intSum = 0;   //定义一个初始值为0的整型变量，用于存储班级的总成绩；
            int i = 1;        //定义一个初始值为0的整型变量，用做循环变量；
            int j;            //定义一个初始值为0的整型变量，用于返回判断输入格式的返回值；
            int k = 1;          //定义一个初始值为0的整型变量，用做循环变量；
            bool b = true;        ////定义一个初始值为true的布尔型变量，用做循环条件；              
            Console.WriteLine("Please input your class number:");           //请用户输入班级的人数； 
            while (b) //此循环语句的作用是判断用户输入的内容格式是否正确,如果用户输入的格式或者范围错误，则提示用户重新输入
            {
                string strNumber = Console.ReadLine();//将用户输入的班级人数赋值给字符串变量strNumber；
                if (int.TryParse(strNumber, out j))  //判断用户输入的内容是否能转换为整型变量；
                {
                    if (int.Parse(strNumber) > 0)    //如果用户输入的内容可以转换为整型变量，则需要判断用户输入的内容是否符合要求，如果用户输入的成绩大于0，则继续下面的语句；
                    {
                        intNumber = int.Parse(strNumber);  //将用户输入的内容转换为整型变量并赋值给intNumber；
                        Console.WriteLine("The class number is:{0}", intNumber);  //输出显示班级的人数；
                        b = false;  //将flase赋值给b.用于结束循环体；
                    }
                    else
                    {
                        Console.WriteLine("The class's number can't be zero,Please input again：");//如果用户输入的数字等于0 ，则提示用户输入错误，程序能进行到这里，说明用户输入的内容可以转换为整型变量，但是输入的范围错误；
                    }
                }
                else
                {
                    Console.WriteLine("The input format is incorrect，This only input a correct number：");//如果这里的程序能运行，则说明对应的if语句中的条件没有得到满足，即用户输入的内容并不能转换成整型变量；
                }
            }

            while (i <= intNumber) //循环条件是i小于或者等于班级的人数;
            {
                Console.WriteLine("Please input the number{0} grades", i); //请用户输入第i个同学的成绩；
                while (k <= i)    //循环的嵌套，只有在满足k<=i的时候执行，用于累加学生的成绩；
                {                   
                        string strGrades = Console.ReadLine();  //将用户输入的第i个同学的成绩赋值给变量；
                        if (int.TryParse(strGrades, out j))   //判断用户输入的内容是否能转换为整型变量；
                        {
                            if (int.Parse(strGrades) >= 0)   //如果用户输入的内容可以转换为整型变量，则还需要判断用户输入的内容是否在合理的范围之内；
                            {
                                intgrades = int.Parse(strGrades); //如果这两个条件都满足，则将用户输入的内容转换成整型变量并赋值给整型变量
                                intSum += intgrades;               //将同学的成绩通过循环体累加，计算班级总成绩；
                                k++; //将循环条件变量加1，继续判断循环条件；将循环变量在这里+1的原因是程序如果执行的这里，则说明用户输入的数据格式完全正确，可以执行下一次循环                            
                            }
                            else
                            {
                                Console.WriteLine("The grades cant't less than zero! Plesse input again:");//如果用户输入的内容不在合理范围之内，则输入错误提示；
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input format is incorrect，This only input a correct number："); //如果用户输入的内容不能够转换为整型变量，则输出错误提示；
                        }               

                }
                i++; //将循环条件变量加1，继续判断循环条件；
            }
            Console.WriteLine("This class's Grade is :{0}", intSum); //将计算得出的总成绩输出到控制台；
            Console.WriteLine("And This class's Grade point average is {0}", intSum / intNumber); //计算平均成绩
            Console.WriteLine("Thanks"); //程序结束!           
            Console.ReadKey();//暂停程序

        }
    }
}
