using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 5, 6, 7, 8, 9 };
            for (int i = 0; i < ints.Length; i++) 
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadKey();
            Console.WriteLine("<><><><><><><><><><><><><><><><><>");
            foreach ( int i in ints ) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
