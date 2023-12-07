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
            int intNumber = 0;
            int intSum = 0;
            int i = 1;
            Console.WriteLine("请输入班级人数：");
            try
            {
                intNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message+ "请输入一个数字：");
            }
            Console.WriteLine("输入正确");
            //try
            //{
            //    Console.WriteLine("Enter a number to divide 100: ");
            //    int divisor = Convert.ToInt32(Console.ReadLine());
            //    int result = 100 / divisor;
            //    Console.WriteLine("Result is: " + result);
            //}
            //catch (DivideByZeroException )
            //{
            //    Console.WriteLine("Cannot divide by zero. Please try again.");
            //}
            //catch (FormatException )
            //{
            //    Console.WriteLine("That's not a valid number. Please try again.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //    throw; // 可以选择重新抛出异常
            //}
            //finally
            //{
            //    // 这里的代码不管是否发生异常都会执行
            //    Console.WriteLine("Thanks for using our program.");
            //}
            Console.ReadKey();

        }
    }
}
