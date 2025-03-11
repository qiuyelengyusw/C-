using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组类型[] 数组名 = new 数组类型[数组长度];
            int[] numbers = new int[10];
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers[5] = 6;
            numbers[6] = 7;
            numbers[7] = 8;
            numbers[8] = 9;
            numbers[9] = 10;
            foreach (int  num in numbers2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }           
            Console.ReadKey();
        }
    }
}
