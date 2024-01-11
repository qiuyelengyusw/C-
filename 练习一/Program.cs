using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket k = new Ticket(251);
            k.ShowTicker();
            Console.ReadKey();
        }
    }
}
