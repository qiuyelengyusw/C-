using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.ReadKey();

            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 <= 10);
            Console.ReadKey();  

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(letter);
            }
            Console.ReadKey();

            //计算1到10之间所有3的倍数的和
            int sum = 0; // 0是初始值
            for (int i=1; i<=10; i++)
            {
                if (i % 3 == 0) // 3的倍数
                {
                    sum += i;  // sum = sum + i
                }
            }
            Console.WriteLine($"The sum is {sum}");
            Console.ReadKey();
        }
    }
}
